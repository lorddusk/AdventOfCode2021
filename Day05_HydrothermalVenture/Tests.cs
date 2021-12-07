using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace Day05_HydrothermalVenture
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleScan_Example_Success()
        {
            // Arrange
            string[] input = new string[]
            {
                "0,9 -> 5,9",
                "8,0 -> 0,8",
                "9,4 -> 3,4",
                "2,2 -> 2,1",
                "7,0 -> 7,4",
                "6,4 -> 2,0",
                "0,9 -> 2,9",
                "3,4 -> 1,4",
                "0,0 -> 8,8",
                "5,5 -> 8,2"
            };

            // Act
            Program.SimpleProgram(input);

            // Assert
            int actualOutput = 0;
            int expectedOutput = 0;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void SimpleScan_Exercise_Success()
        {
            // Arrange
            string[] input = Utils.Input("day05");

            // Act
            Program.SimpleProgram(input);

            // Assert
            int actualOutput = 0;
            int expectedOutput = 0;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void AdvancedScan_Example_Success()
        {
            // Arrange
            string[] input = new string[]
            {
                "0,9 -> 5,9",
                "8,0 -> 0,8",
                "9,4 -> 3,4",
                "2,2 -> 2,1",
                "7,0 -> 7,4",
                "6,4 -> 2,0",
                "0,9 -> 2,9",
                "3,4 -> 1,4",
                "0,0 -> 8,8",
                "5,5 -> 8,2"
            };

            // Act
            Program.AdvancedProgram(input);

            // Assert
            int actualOutput = 0;
            int expectedOutput = 0;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void AdvancedScan_Exercise_Success()
        {
            // Arrange
            string[] input = Utils.Input("day05");

            // Act
            Program.AdvancedProgram(input);

            // Assert
            int actualOutput = 0;
            int expectedOutput = 0;
            actualOutput.Should().Be(expectedOutput);
        }
    }
}