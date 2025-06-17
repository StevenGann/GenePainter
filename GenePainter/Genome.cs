using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Linq;

namespace GenePainter
{
    /// <summary>
    /// Represents the type of shape that can be drawn by a gene.
    /// </summary>
    public enum ShapeType
    {
        Rectangle,
        Ellipse,
        Triangle
    }

    public class Gene
    {
        private float[] values;
        
        // Array indices
        private const int X_INDEX = 0;
        private const int Y_INDEX = 1;
        private const int WIDTH_INDEX = 2;
        private const int HEIGHT_INDEX = 3;
        private const int HUE_INDEX = 4;
        private const int SATURATION_INDEX = 5;
        private const int VALUE_INDEX = 6;
        private const int ALPHA_INDEX = 7;
        private const int SHAPE_TYPE_INDEX = 8;

        /// <summary>
        /// Gets or sets the X position of the shape as a percentage of the canvas width.
        /// </summary>
        public float X { get => values[X_INDEX] % 1f; set => values[X_INDEX] = value % 1f; }

        /// <summary>
        /// Gets or sets the Y position of the shape as a percentage of the canvas height.
        /// </summary>
        public float Y { get => values[Y_INDEX] % 1f; set => values[Y_INDEX] = value % 1f; }

        /// <summary>
        /// Gets or sets the width of the shape as a percentage of the canvas width.
        /// </summary>
        public float Width { get => values[WIDTH_INDEX] % 1f; set => values[WIDTH_INDEX] = value % 1f; }

        /// <summary>
        /// Gets or sets the height of the shape as a percentage of the canvas height.
        /// </summary>
        public float Height { get => values[HEIGHT_INDEX] % 1f; set => values[HEIGHT_INDEX] = value % 1f; }

        /// <summary>
        /// Gets or sets the hue component of the shape's color, in the range of 0 to 255.
        /// </summary>
        public float Hue { get => 255f * (values[HUE_INDEX] % 1f); set => values[HUE_INDEX] = (value / 255f) % 1f; }

        /// <summary>
        /// Gets or sets the saturation component of the shape's color, in the range of 0 to 255.
        /// </summary>
        public float Saturation { get => 255f * (values[SATURATION_INDEX] % 1f); set => values[SATURATION_INDEX] = (value / 255f) % 1f; }

        /// <summary>
        /// Gets or sets the value (brightness) component of the shape's color, in the range of 0 to 255.
        /// </summary>
        public float Value { get => 255f * (values[VALUE_INDEX] % 1f); set => values[VALUE_INDEX] = (value / 255f) % 1f; }

        /// <summary>
        /// Gets or sets the alpha (transparency) component of the shape's color, in the range of 0 to 255.
        /// </summary>
        public float Alpha { get => 255f * (values[ALPHA_INDEX] % 1f); set => values[ALPHA_INDEX] = (value / 255f) % 1f; }

        /// <summary>
        /// Gets or sets the type of shape to be drawn.
        /// </summary>
        public ShapeType ShapeType 
        { 
            get => (ShapeType)(values[SHAPE_TYPE_INDEX] % Enum.GetValues(typeof(ShapeType)).Length); 
            set => values[SHAPE_TYPE_INDEX] = (float)value; 
        }

        /// <summary>
        /// Gets the raw array of float values representing all properties of the gene.
        /// </summary>
        public float[] Values => values;

        public Gene()
        {
            values = new float[9]; // 8 float properties + 1 for shape type
            var random = new Random();
            
            // Initialize all values in 0-1 range
            values[X_INDEX] = (float)random.NextDouble();
            values[Y_INDEX] = (float)random.NextDouble();
            values[WIDTH_INDEX] = (float)random.NextDouble() * 0.5f; // Max 50% of canvas width
            values[HEIGHT_INDEX] = (float)random.NextDouble() * 0.5f; // Max 50% of canvas height
            values[HUE_INDEX] = (float)random.NextDouble();
            values[SATURATION_INDEX] = (float)random.NextDouble();
            values[VALUE_INDEX] = (float)random.NextDouble();
            values[ALPHA_INDEX] = (float)random.NextDouble();
            values[SHAPE_TYPE_INDEX] = random.Next(0, Enum.GetValues(typeof(ShapeType)).Length);
        }

        public Gene Clone()
        {
            var clone = new Gene();
            Array.Copy(this.values, clone.values, this.values.Length);
            return clone;
        }
    }

    /// <summary>
    /// Represents a collection of genes that together form a complete image approximation.
    /// Each gene represents a shape with its position, size, color, and type.
    /// </summary>
    public class Genome
    {
        /// <summary>
        /// Gets the list of genes that make up this genome.
        /// </summary>
        public List<Gene> Genes { get; private set; }

        /// <summary>
        /// Gets or sets the fitness score of this genome, representing how well it approximates the target image.
        /// Higher values indicate better approximation.
        /// </summary>
        public float Fitness { get; set; }

        /// <summary>
        /// Initializes a new instance of the Genome class with a specified number of genes.
        /// </summary>
        /// <param name="geneCount">The number of genes to create in this genome.</param>
        public Genome(int geneCount)
        {
            Genes = new List<Gene>();
            for (int i = 0; i < geneCount; i++)
            {
                Genes.Add(new Gene());
            }
            Fitness = 0;
        }

        /// <summary>
        /// Creates a deep copy of this genome, including all its genes.
        /// </summary>
        /// <returns>A new Genome instance that is a complete copy of this genome.</returns>
        public Genome Clone()
        {
            var clone = new Genome(0);
            clone.Genes = new List<Gene>(this.Genes.Select(g => g.Clone()));
            clone.Fitness = this.Fitness;
            return clone;
        }

        /// <summary>
        /// Applies random mutations to the genes in this genome.
        /// Each gene has a chance to mutate based on the mutation rate.
        /// </summary>
        /// <param name="mutationRate">The probability (0-1) that each gene will mutate.</param>
        public void Mutate(float mutationRate)
        {
            var random = new Random();

            // Determine which types of mutations to apply
            if (random.NextDouble() < mutationRate * 0.2) // 20% chance of structural mutations
            {
                switch (random.Next(5)) // 5 types of structural mutations
                {
                    case 0: // Gene addition
                        if (Genes.Count < 100) // Prevent unlimited growth
                        {
                            int insertIndex = random.Next(Genes.Count + 1);
                            Genes.Insert(insertIndex, new Gene());
                        }
                        break;

                    case 1: // Gene transposition
                        if (Genes.Count > 1)
                        {
                            int fromIndex = random.Next(Genes.Count);
                            int toIndex = random.Next(Genes.Count);
                            var gene = Genes[fromIndex];
                            Genes.RemoveAt(fromIndex);
                            Genes.Insert(toIndex, gene);
                        }
                        break;

                    case 2: // Gene deletion
                        if (Genes.Count > 1) // Keep at least one gene
                        {
                            int deleteIndex = random.Next(Genes.Count);
                            Genes.RemoveAt(deleteIndex);
                        }
                        break;

                    case 3: // Gene duplication
                        if (Genes.Count < 100) // Prevent unlimited growth
                        {
                            int dupIndex = random.Next(Genes.Count);
                            Genes.Insert(dupIndex, Genes[dupIndex].Clone());
                        }
                        break;

                    case 4: // Gene inversion
                        if (Genes.Count > 2)
                        {
                            int start = random.Next(Genes.Count - 1);
                            int length = random.Next(2, Math.Min(5, Genes.Count - start));
                            Genes.Reverse(start, length);
                        }
                        break;
                }
            }

            // Apply property mutations to existing genes
            foreach (var gene in Genes)
            {
                if (random.NextDouble() < mutationRate)
                {
                    // Determine mutation type for this gene
                    switch (random.Next(9)) // 9 types of mutations
                    {
                        case 0: // Random property change
                            switch (random.Next(8))
                            {
                                case 0: gene.X = (float)random.NextDouble(); break;
                                case 1: gene.Y = (float)random.NextDouble(); break;
                                case 2: gene.Width = (float)random.NextDouble() * 0.5f; break;
                                case 3: gene.Height = (float)random.NextDouble() * 0.5f; break;
                                case 4: gene.Hue = (float)random.NextDouble() * 255f; break;
                                case 5: gene.Saturation = (float)random.NextDouble() * 255f; break;
                                case 6: gene.Value = (float)random.NextDouble() * 255f; break;
                                case 7: gene.Alpha = (float)random.NextDouble() * 255f; break;
                            }
                            break;

                        case 1: // Small random adjustment to all properties
                            float adjustment = (float)(random.NextDouble() * 0.2 - 0.1); // -0.1 to 0.1
                            gene.X = (gene.X + adjustment + 1) % 1f;
                            gene.Y = (gene.Y + adjustment + 1) % 1f;
                            gene.Width = Math.Max(0.01f, Math.Min(0.5f, gene.Width * (1 + adjustment)));
                            gene.Height = Math.Max(0.01f, Math.Min(0.5f, gene.Height * (1 + adjustment)));
                            gene.Hue = (gene.Hue + adjustment * 255f + 255f) % 255f;
                            gene.Saturation = (gene.Saturation + adjustment * 255f + 255f) % 255f;
                            gene.Value = (gene.Value + adjustment * 255f + 255f) % 255f;
                            gene.Alpha = (gene.Alpha + adjustment * 255f + 255f) % 255f;
                            break;

                        case 2: // Color shift
                            float hueShift = (float)(random.NextDouble() * 30 - 15); // -15 to 15
                            gene.Hue = (gene.Hue + hueShift + 255f) % 255f;
                            break;

                        case 3: // Size adjustment
                            float sizeFactor = (float)(random.NextDouble() * 0.4 + 0.8); // 0.8 to 1.2
                            gene.Width = Math.Max(0.01f, Math.Min(0.5f, gene.Width * sizeFactor));
                            gene.Height = Math.Max(0.01f, Math.Min(0.5f, gene.Height * sizeFactor));
                            break;

                        case 4: // Position shift
                            float posShift = (float)(random.NextDouble() * 0.2 - 0.1); // -0.1 to 0.1
                            gene.X = (gene.X + posShift + 1) % 1f;
                            gene.Y = (gene.Y + posShift + 1) % 1f;
                            break;

                        case 5: // Transparency adjustment
                            float alphaAdjust = (float)(random.NextDouble() * 0.4 - 0.2); // -0.2 to 0.2
                            gene.Alpha = Math.Max(0, Math.Min(255, gene.Alpha + alphaAdjust * 255f));
                            break;

                        case 6: // Shape type change
                            gene.ShapeType = (ShapeType)random.Next(Enum.GetValues(typeof(ShapeType)).Length);
                            break;

                        case 7: // Color intensity adjustment
                            float intensityAdjust = (float)(random.NextDouble() * 0.4 - 0.2); // -0.2 to 0.2
                            gene.Saturation = Math.Max(0, Math.Min(255, gene.Saturation + intensityAdjust * 255f));
                            gene.Value = Math.Max(0, Math.Min(255, gene.Value + intensityAdjust * 255f));
                            break;

                        case 8: // Aspect ratio adjustment
                            float aspectAdjust = (float)(random.NextDouble() * 0.4 - 0.2); // -0.2 to 0.2
                            gene.Width = Math.Max(0.01f, Math.Min(0.5f, gene.Width * (1 + aspectAdjust)));
                            gene.Height = Math.Max(0.01f, Math.Min(0.5f, gene.Height * (1 - aspectAdjust)));
                            break;
                    }
                }
            }
        }

        /// <summary>
        /// Serializes this genome to a JSON string.
        /// </summary>
        /// <returns>A JSON string representation of this genome.</returns>
        public string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions 
            { 
                WriteIndented = true 
            });
        }

        /// <summary>
        /// Creates a new Genome instance from a JSON string.
        /// </summary>
        /// <param name="json">The JSON string to deserialize.</param>
        /// <returns>A new Genome instance created from the JSON string.</returns>
        public static Genome FromJson(string json)
        {
            return JsonSerializer.Deserialize<Genome>(json);
        }

        /// <summary>
        /// Serializes this genome to a single array of floats.
        /// The array contains all gene values followed by the fitness value.
        /// </summary>
        /// <returns>An array of floats representing this genome.</returns>
        public float[] ToArray()
        {
            // Calculate total size: (number of genes * values per gene) + 1 for fitness
            int valuesPerGene = 9; // X, Y, Width, Height, Hue, Saturation, Value, Alpha, ShapeType
            int totalSize = (Genes.Count * valuesPerGene) + 1;
            var result = new float[totalSize];

            // Copy all gene values
            for (int i = 0; i < Genes.Count; i++)
            {
                Array.Copy(Genes[i].Values, 0, result, i * valuesPerGene, valuesPerGene);
            }

            // Add fitness at the end
            result[totalSize - 1] = Fitness;

            return result;
        }

        /// <summary>
        /// Creates a new Genome instance from an array of floats.
        /// </summary>
        /// <param name="array">The array of floats to deserialize.</param>
        /// <returns>A new Genome instance created from the array.</returns>
        /// <exception cref="ArgumentException">Thrown when the array length is invalid.</exception>
        public static Genome FromArray(float[] array)
        {
            if (array == null || array.Length < 10) // Minimum: 1 gene (9 values) + 1 fitness
                throw new ArgumentException("Array must contain at least 10 values (1 gene + fitness)");

            int valuesPerGene = 9;
            int geneCount = (array.Length - 1) / valuesPerGene; // -1 for fitness

            if ((array.Length - 1) % valuesPerGene != 0)
                throw new ArgumentException("Invalid array length. Must be (number of genes * 9) + 1");

            var genome = new Genome(geneCount);
            
            // Copy gene values
            for (int i = 0; i < geneCount; i++)
            {
                Array.Copy(array, i * valuesPerGene, genome.Genes[i].Values, 0, valuesPerGene);
            }

            // Set fitness
            genome.Fitness = array[array.Length - 1];

            return genome;
        }
    }
}