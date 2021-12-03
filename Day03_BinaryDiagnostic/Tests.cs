using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace Day03_BinaryDiagnostic
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleDiagnostic_Example_Success()
        {
            // Arrange
            string[] stringInput = new string[] {"00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

            // Act
            (int gamma, int epsilon) = Program.SimpleDiagnostic(stringInput);

            // Assert
            int expectedOutput = 198;
            expectedOutput.Should().Be(gamma*epsilon);
        }

        [TestMethod]
        public void SimpleDiagnostic_Exercise_Success()
        {
            // Arrange
            string[] stringInput = Utils.Input("day03");
            
            // Act
            (int gamma, int epsilon) = Program.SimpleDiagnostic(stringInput);

            // Assert
            int expectedOutput = 4191876;
            expectedOutput.Should().Be(gamma*epsilon);
        }
        
        [TestMethod]
        public void AdvancedDiagnostic_Example_Success()
        {
            // Arrange
            string[] stringInput = new string[] {"00100",
                "11110",
                "10110",
                "10111",
                "10101",
                "01111",
                "00111",
                "11100",
                "10000",
                "11001",
                "00010",
                "01010"};

            // Act
            (int oxygen, int co2) = Program.AdvancedDiagnostic(stringInput);

            // Assert
            int expectedOutput = 230;
            expectedOutput.Should().Be(oxygen*co2);
        }
        
        [TestMethod]
        public void AdvancedScan_Exercise_Success()
        {
            // Arrange
            string[] stringInput = Utils.Input("day03");
            
            // Act
            (int oxygen, int co2) = Program.AdvancedDiagnostic(stringInput);

            // Assert
            int expectedOutput = 3414905;
            expectedOutput.Should().Be(oxygen*co2);
        }
    }
}