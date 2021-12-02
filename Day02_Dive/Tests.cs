using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utils;

namespace Day02_Dive
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleMove_Example_Success()
        {
            // Arrange
            string[] stringInput = new string[] {"forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"};

            // Act
            (int horizontal, int depth) = Program.SimpleMove(stringInput);

            // Assert
            int expectedOutput = 150;
            expectedOutput.Should().Be(horizontal*depth);
        }

        [TestMethod]
        public void SimpleMove_Exercise_Success()
        {
            // Arrange
            string[] stringInput = Read.Input("day02");
            
            // Act
            (int horizontal, int depth) = Program.SimpleMove(stringInput);

            // Assert
            int expectedOutput = 1383564;
            expectedOutput.Should().Be(horizontal*depth);
        }
        
        [TestMethod]
        public void AdvancedMove_Example_Success()
        {
            // Arrange
            string[] stringInput = new string[] {"forward 5",
                "down 5",
                "forward 8",
                "up 3",
                "down 8",
                "forward 2"};

            // Act
            (int horizontal, int depth) = Program.AdvancedMove(stringInput);

            // Assert
            int expectedOutput = 900;
            expectedOutput.Should().Be(horizontal*depth);
        }
        
        [TestMethod]
        public void AdvancedScan_Exercise_Success()
        {
            // Arrange
            string[] stringInput = Read.Input("day02");
            
            // Act
            (int horizontal, int depth) = Program.AdvancedMove(stringInput);

            // Assert
            int expectedOutput = 1488311643;
            expectedOutput.Should().Be(horizontal*depth);
        }
    }
}