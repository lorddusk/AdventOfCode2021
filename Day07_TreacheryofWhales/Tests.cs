using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace Day07_TreacheryofWhales
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleScan_Example_Success()
        {
            // Arrange
            int[] input = new int[] {16,1,2,0,4,2,7,1,2,14};

            // Act
            int actualOutput = Program.SimpleProgram(input);

            // Assert
            int expectedOutput = 37;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void SimpleScan_Exercise_Success()
        {
            // Arrange
            string[] strInput = Utils.Input("day07");
            int[] input = Utils.StringToIntArray(strInput[0].Split(","));

            // Act
            int actualOutput = Program.SimpleProgram(input);

            // Assert
            int expectedOutput = 352254;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void AdvancedScan_Example_Success()
        {
            // Arrange
            int[] input = new int[] {16,1,2,0,4,2,7,1,2,14};

            // Act
            int actualOutput = Program.AdvancedProgram(input);

            // Assert
            int expectedOutput = 168;
            actualOutput.Should().Be(expectedOutput);
        }

        [TestMethod]
        public void AdvancedScan_Exercise_Success()
        {
            // Arrange
            string[] strInput = Utils.Input("day07");
            int[] input = Utils.StringToIntArray(strInput[0].Split(","));

            // Act
            int actualOutput = Program.AdvancedProgram(input);

            // Assert
            int expectedOutput = 99053143;
            actualOutput.Should().Be(expectedOutput);
        }
    }
}