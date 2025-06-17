using System;
using System.Collections.Generic;
using System.Linq;
using Raylib_cs;

namespace GenePainter
{
    public static class GenePool
    {
        private static List<Genome> population = new List<Genome>();
        private static GeneticTexture texture;
        private static readonly float mutationRate = 0.3f;
        private static int maxPopulationSize;

        public static Raylib_cs.Image Target;

        /// <summary>
        /// Initializes the gene pool with a specified number of genomes.
        /// </summary>
        /// <param name="initialPopulationSize">The number of genomes to create initially.</param>
        /// <param name="genesPerGenome">The number of genes each genome should have.</param>
        /// <param name="textureResolution">The resolution to use for rendering genomes.</param>
        /// <param name="maxPopulationSize">The maximum number of genomes allowed in the population.</param>
        public static void Initialize(int initialPopulationSize, int genesPerGenome, int textureResolution, int maxPopulationSize)
        {
            if (initialPopulationSize > maxPopulationSize)
                throw new ArgumentException("Initial population size cannot be greater than maximum population size");

            GenePool.maxPopulationSize = maxPopulationSize;

            // Create initial population
            population = new List<Genome>();
            for (int i = 0; i < initialPopulationSize; i++)
            {
                population.Add(new Genome(genesPerGenome));
            }

            // Initialize texture
            texture = new GeneticTexture(textureResolution);
        }

        /// <summary>
        /// Performs one generation of evolution:
        /// 1. Truncates the population to the maximum size if necessary
        /// 2. Expands the population by copying and mutating existing genomes
        /// 3. Renders the population using GeneticTexture
        /// 4. Sorts the population by fitness
        /// </summary>
        /// <returns>The rendered texture containing all genomes in the population.</returns>
        public static Texture2D Generation()
        {
            if (population == null || population.Count == 0)
                throw new InvalidOperationException("GenePool must be initialized before calling Generation");

            // Truncate population to maximum size if necessary
            if (population.Count > maxPopulationSize / 10)
            {
                population = population.Take(maxPopulationSize / 10).ToList();
            }

            // Expand population by copying and mutating existing genomes
            var newGenomes = new List<Genome>();
            while(population.Count < maxPopulationSize)
            {
            foreach (var genome in population)
            {
                var clone = genome.Clone();
                clone.Mutate(mutationRate);
                newGenomes.Add(clone);
            }
            population.AddRange(newGenomes);
            }

            // Render the population
            var result = texture.RenderGenomes(population, texture.Resolution, Target);

            // Sort population by fitness (descending)
            population = population.OrderByDescending(g => g.Fitness).ToList();

            return result;
        }

        /// <summary>
        /// Gets the current population of genomes.
        /// </summary>
        public static IReadOnlyList<Genome> Population => population.AsReadOnly();
    }
}