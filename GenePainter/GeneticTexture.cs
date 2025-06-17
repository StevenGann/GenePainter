using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.InteropServices;
using Raylib_cs;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using Color = Raylib_cs.Color;
using ImageSharpImage = SixLabors.ImageSharp.Image;

namespace GenePainter
{
    public class GeneticTexture
    {
        private RenderTexture2D renderTexture;
        private readonly int resolution;
        private const int SAMPLE_COUNT = 100; // Number of random pixels to sample

        /// <summary>
        /// Gets the resolution used for rendering genomes.
        /// </summary>
        public int Resolution => resolution;

        public GeneticTexture(int resolution)
        {
            this.resolution = resolution;
        }

        /// <summary>
        /// Renders a collection of genomes to a GPU texture.
        /// </summary>
        /// <param name="genomes">The genomes to render.</param>
        /// <param name="resolution">The width and height in pixels for each genome's rendering area.</param>
        public Texture2D RenderGenomes(IReadOnlyList<Genome> genomes, int resolution, Raylib_cs.Image target)
        {
            if (genomes == null || genomes.Count == 0)
                throw new ArgumentException("Genomes list cannot be null or empty", nameof(genomes));

            if (resolution <= 0)
                throw new ArgumentException("Resolution must be greater than 0", nameof(resolution));

            // Calculate the grid dimensions needed to fit all genomes
            int gridSize = (int)Math.Ceiling(Math.Sqrt(genomes.Count));
            
            // Calculate the total size needed
            int totalSize = gridSize * resolution;
            
            // Find the next power of two that can fit all genomes
            int textureSize = NextPowerOfTwo(totalSize);

            // Create or resize the render texture if needed
            if (renderTexture.Texture.Width != textureSize || renderTexture.Texture.Height != textureSize)
            {
                if (renderTexture.Texture.Width != 0) // If we already have a texture, unload it
                    Raylib.UnloadRenderTexture(renderTexture);
                    
                renderTexture = Raylib.LoadRenderTexture(textureSize, textureSize);
            }

            // Clear the texture
            Raylib.BeginTextureMode(renderTexture);
            Raylib.ClearBackground(new Color(0, 0, 0, 0));

            // Render each genome in its grid position
            for (int i = 0; i < genomes.Count; i++)
            {
                int row = i / gridSize;
                int col = i % gridSize;
                int x = col * resolution;
                int y = row * resolution;

                RenderGenome(genomes[i], x, y, resolution);
            }

            Raylib.EndTextureMode();

            // Convert the render texture to an image for fitness evaluation
            var renderImage = Raylib.LoadImageFromTexture(renderTexture.Texture);

            // Evaluate fitness for each genome
            for (int i = 0; i < genomes.Count; i++)
            {
                int row = i / gridSize;
                int col = i % gridSize;
                int x = col * resolution;
                int y = row * resolution;

                genomes[i].Fitness = EvaluateFitness(renderImage, target, x, y, resolution);
            }

            // Clean up the temporary image
            Raylib.UnloadImage(renderImage);

            return renderTexture.Texture;
        }

        private unsafe float EvaluateFitness(Raylib_cs.Image candidate, Raylib_cs.Image target, int x, int y, int resolution)
        {
            var random = new Random();
            float totalDifference = 0;

            // Sample random pixels and compare
            for (int i = 0; i < SAMPLE_COUNT; i++)
            {
                // Generate random coordinates within the genome's area
                int sampleX = random.Next(resolution);
                int sampleY = random.Next(resolution);

                // Get colors from both images
                Color candidateColor = Raylib.GetImageColor(candidate, sampleX + x, sampleY + y);
                Color targetColor = Raylib.GetImageColor(target, sampleX, sampleY);

                // Calculate color difference (RGB distance)
                float rDiff = candidateColor.R - targetColor.R;
                float gDiff = candidateColor.G - targetColor.G;
                float bDiff = candidateColor.B - targetColor.B;

                // Sum of squared differences
                totalDifference += (rDiff * rDiff + gDiff * gDiff + bDiff * bDiff);
            }

            // Convert to fitness score (1 / (1 + totalDifference))
            // Adding 1 to avoid division by zero
            float fitness = 1f / (0.1f + totalDifference);
            //Console.WriteLine(fitness);
            return fitness;
        }

        private void RenderGenome(Genome genome, int offsetX, int offsetY, int resolution)
        {
            // Set scissor mode to clip drawing to this genome's area
            Raylib.BeginScissorMode(offsetX, offsetY, resolution, resolution);

            // Draw the first gene as a full-size background
            if (genome.Genes.Count > 0)
            {
                var firstGene = genome.Genes[0];
                Color color = ColorFromHSV(firstGene.Hue, firstGene.Saturation, firstGene.Value, firstGene.Alpha);
                Raylib.DrawRectangle(offsetX, offsetY, resolution, resolution, color);
            }

            // Draw remaining genes on top
            for (int i = 1; i < genome.Genes.Count; i++)
            {
                var gene = genome.Genes[i];
                // Convert normalized coordinates to pixel coordinates
                float x = offsetX + (gene.X * resolution);
                float y = offsetY + (gene.Y * resolution);
                float width = gene.Width * resolution;
                float height = gene.Height * resolution;

                // Convert HSV to RGB
                Color color = ColorFromHSV(gene.Hue, gene.Saturation, gene.Value, gene.Alpha);

                // Draw shape based on type
                switch (gene.ShapeType)
                {
                    case ShapeType.Rectangle:
                        Raylib.DrawRectangle((int)x, (int)y, (int)width, (int)height, color);
                        break;
                    case ShapeType.Ellipse:
                        Raylib.DrawEllipse((int)(x + width/2), (int)(y + height/2), width/2, height/2, color);
                        break;
                    case ShapeType.Triangle:
                        Vector2[] points = new Vector2[]
                        {
                            new Vector2(x + width/2, y),
                            new Vector2(x, y + height),
                            new Vector2(x + width, y + height)
                        };
                        Raylib.DrawTriangle(points[0], points[1], points[2], color);
                        break;
                }
            }

            // End scissor mode
            Raylib.EndScissorMode();
        }

        private static Color ColorFromHSV(float hue, float saturation, float value, float alpha)
        {
            // Convert from 0-255 range to 0-1 range
            hue /= 255f;
            saturation /= 255f;
            value /= 255f;
            alpha /= 255f;

            int hi = (int)(hue * 6);
            float f = hue * 6 - hi;
            float p = value * (1 - saturation);
            float q = value * (1 - f * saturation);
            float t = value * (1 - (1 - f) * saturation);

            float r, g, b;
            switch (hi)
            {
                case 0: r = value; g = t; b = p; break;
                case 1: r = q; g = value; b = p; break;
                case 2: r = p; g = value; b = t; break;
                case 3: r = p; g = q; b = value; break;
                case 4: r = t; g = p; b = value; break;
                default: r = value; g = p; b = q; break;
            }

            return new Color(
                (byte)(r * 255),
                (byte)(g * 255),
                (byte)(b * 255),
                (byte)(alpha * 255)
            );
        }

        private static int NextPowerOfTwo(int n)
        {
            n--;
            n |= n >> 1;
            n |= n >> 2;
            n |= n >> 4;
            n |= n >> 8;
            n |= n >> 16;
            n++;
            return n;
        }
    }
}