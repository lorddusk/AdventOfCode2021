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
            string[] stringInput = Read.Input("day01");
            int[] input = Read.StringToIntArray(stringInput);

            // Act
            int actualOutput = Program.SimpleScan(input);

            // Assert
            int expectedOutput = 1266;
            expectedOutput.Should().Be(actualOutput);
        }

        [TestMethod]
        public void AdvancedScan_Example_Success()
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
        public void AdvancedScan_Exercise_Success()
        {
            // Arrange
            string[] stringInput = Read.Input("day01");
            int[] input = Read.StringToIntArray(stringInput);

            // Act
            int actualOutput = Program.AdvancedScan(input);

            // Assert
            int expectedOutput = 1217;
            expectedOutput.Should().Be(actualOutput);
        }
    }
}