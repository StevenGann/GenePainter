using System;
using System.Linq;
using Xunit;
using GenePainter;

namespace GenePainter.Tests
{
    public class GenomeTests
    {
        [Fact]
        public void Genome_JsonSerialization_PreservesAllProperties()
        {
            // Arrange
            var original = new Genome(10); // Create a genome with 10 genes
            original.Fitness = 0.75f;      // Set a specific fitness value

            // Act
            string json = original.ToJson();
            var deserialized = Genome.FromJson(json);

            // Assert
            Assert.Equal(original.Fitness, deserialized.Fitness);
            Assert.Equal(original.Genes.Count, deserialized.Genes.Count);

            // Compare each gene's properties
            for (int i = 0; i < original.Genes.Count; i++)
            {
                var originalGene = original.Genes[i];
                var deserializedGene = deserialized.Genes[i];

                Assert.Equal(originalGene.X, deserializedGene.X);
                Assert.Equal(originalGene.Y, deserializedGene.Y);
                Assert.Equal(originalGene.Width, deserializedGene.Width);
                Assert.Equal(originalGene.Height, deserializedGene.Height);
                Assert.Equal(originalGene.Hue, deserializedGene.Hue);
                Assert.Equal(originalGene.Saturation, deserializedGene.Saturation);
                Assert.Equal(originalGene.Value, deserializedGene.Value);
                Assert.Equal(originalGene.Alpha, deserializedGene.Alpha);
                Assert.Equal(originalGene.ShapeType, deserializedGene.ShapeType);
            }
        }

        [Fact]
        public void Genome_ArraySerialization_PreservesAllProperties()
        {
            // Arrange
            var original = new Genome(10); // Create a genome with 10 genes
            original.Fitness = 0.75f;      // Set a specific fitness value

            // Act
            float[] array = original.ToArray();
            var deserialized = Genome.FromArray(array);

            // Assert
            Assert.Equal(original.Fitness, deserialized.Fitness);
            Assert.Equal(original.Genes.Count, deserialized.Genes.Count);

            // Compare each gene's properties
            for (int i = 0; i < original.Genes.Count; i++)
            {
                var originalGene = original.Genes[i];
                var deserializedGene = deserialized.Genes[i];

                Assert.Equal(originalGene.X, deserializedGene.X);
                Assert.Equal(originalGene.Y, deserializedGene.Y);
                Assert.Equal(originalGene.Width, deserializedGene.Width);
                Assert.Equal(originalGene.Height, deserializedGene.Height);
                Assert.Equal(originalGene.Hue, deserializedGene.Hue);
                Assert.Equal(originalGene.Saturation, deserializedGene.Saturation);
                Assert.Equal(originalGene.Value, deserializedGene.Value);
                Assert.Equal(originalGene.Alpha, deserializedGene.Alpha);
                Assert.Equal(originalGene.ShapeType, deserializedGene.ShapeType);
            }
        }

        [Fact]
        public void Genome_FromArray_ThrowsOnInvalidLength()
        {
            // Arrange
            float[] invalidArray = new float[8]; // Too short (need at least 10 values)

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Genome.FromArray(invalidArray));
        }

        [Fact]
        public void Genome_FromArray_ThrowsOnInvalidFormat()
        {
            // Arrange
            float[] invalidArray = new float[11]; // Not divisible by 9 (values per gene) + 1

            // Act & Assert
            Assert.Throws<ArgumentException>(() => Genome.FromArray(invalidArray));
        }
    }
} 