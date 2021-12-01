using FluentAssertions;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace Day01_SonarSweep
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleScan_Example_Success()
        {
            // Arrange
            int[] input = new int[] {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};

            // Act
            int actualOutput = Program.SimpleScan(input);

            // Assert
            int expectedOutput = 7;
            expectedOutput.Should().Be(actualOutput);
        }

        [TestMethod]
        public void SimpleScan_Exercise_Success()
        {
            // Arrange
            var input = Read.Input("day01");
            int[] intInputs = new int[input.Length];
            int i = 0;
            foreach (var line in input)
            {
                intInputs[i] = int.Parse(input[i]);
                i++;
            }

            // Act
            int actualOutput = Program.SimpleScan(intInputs);

            // Assert
            int expectedOutput = 1266;
            expectedOutput.Should().Be(actualOutput);
        }

        [TestMethod]
        public void AdvancedScan_Example_Succes()
        {
            // Arrange
            int[] input = new int[] {199, 200, 208, 210, 200, 207, 240, 269, 260, 263};

            // Act
            int actualOutput = Program.AdvancedScan(input);

            // Assert
            int expectedOutput = 5;
            expectedOutput.Should().Be(actualOutput);
        }

        [TestMethod]
        public void AdvancedScan_Exercise_Succes()
        {
            // Arrange
            var input = Read.Input("day01");
            int[] intInputs = new int[input.Length];
            int i = 0;
            foreach (var line in input)
            {
                intInputs[i] = int.Parse(input[i]);
                i++;
            }

            // Act
            int actualOutput = Program.AdvancedScan(intInputs);

            // Assert
            int expectedOutput = 1217;
            expectedOutput.Should().Be(actualOutput);
        }
    }
}