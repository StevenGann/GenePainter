using System.Collections.Generic;
using Raylib_cs;
using System.Numerics;

namespace GenePainter
{
    class Program
    {
        static void Main(string[] args)
        {
            const int screenWidth = 1024;
            const int screenHeight = 1024;
            const int genomeCount = 8;
            const int resolution = 256; // Resolution for each genome

            // Initialize Raylib
            Raylib.InitWindow(screenWidth, screenHeight, "GenePainter - 1024 Genomes");
            Raylib.SetTargetFPS(60);

            // Create genetic texture
            var texture = new GeneticTexture(resolution);

            // Generate random genomes
            var genomes = new List<Genome>();
            var random = new Random(42); // Fixed seed for reproducibility
            for (int i = 0; i < genomeCount; i++)
            {
                var genome = new Genome(5); // Create genome with 5 genes
                genomes.Add(genome);
            }

            // Render genomes to texture
            var result = texture.RenderGenomes(genomes, resolution);

            // Main game loop
            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(new Color(0, 0, 0, 255));

                // Draw the texture, scaling it to fit the window
                var srcRect = new Rectangle(0, 0, result.Width, result.Height);
                var destRect = new Rectangle(0, 0, screenWidth, screenHeight);
                Raylib.DrawTexturePro(result, srcRect, destRect, new Vector2(0, 0), 0, new Color(255, 255, 255, 255));

                // Draw FPS
                Raylib.DrawFPS(10, 10);

                Raylib.EndDrawing();
            }

            // Cleanup
            Raylib.CloseWindow();
        }
    }
}
