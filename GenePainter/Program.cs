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
            const int initialPopulationSize = 100; // Start with a small population
            const int genesPerGenome = 64; 
            const int resolution = 512; // Resolution for each genome
            const int maxPopulationSize = 256; // Maximum number of genomes allowed

            // Initialize Raylib
            Raylib.InitWindow(screenWidth, screenHeight, "GenePainter - Evolving Genomes");
            Raylib.SetTargetFPS(60);

            // Load and prepare target image
            Image targetImage = Raylib.LoadImage("target.png");
            if (targetImage.Width == 0 || targetImage.Height == 0)
            {
                Raylib.CloseWindow();
                System.Console.WriteLine("Error: Could not load target.png");
                return;
            }

            // Scale target image to be square and match resolution
            Raylib.ImageResize(ref targetImage, resolution, resolution);

            // Initialize GenePool with target
            GenePool.Initialize(initialPopulationSize, genesPerGenome, resolution, maxPopulationSize);
            GenePool.Target = targetImage;

            // Main game loop
            while (!Raylib.WindowShouldClose())
            {
                // Perform one generation of evolution
                var result = GenePool.Generation();

                Raylib.BeginDrawing();
                Raylib.ClearBackground(new Color(0, 0, 0, 255));

                // Draw the texture, scaling it to fit the window
                var srcRect = new Rectangle(0, 0, result.Width, result.Height);
                var destRect = new Rectangle(0, 0, screenWidth, screenHeight);
                Raylib.DrawTexturePro(result, srcRect, destRect, new Vector2(0, 0), 0, new Color(255, 255, 255, 255));

                // Draw FPS and population info
                Raylib.DrawFPS(10, 10);
                Raylib.DrawText($"Population Size: {GenePool.Population.Count}", 10, 40, 20, new Color(255, 255, 255, 255));
                Raylib.DrawText($"Best Fitness: {GenePool.Population[0].Fitness:F2}", 10, 70, 20, new Color(255, 255, 255, 255));

                Raylib.EndDrawing();
            }

            // Cleanup
            Raylib.CloseWindow();
        }
    }
}
