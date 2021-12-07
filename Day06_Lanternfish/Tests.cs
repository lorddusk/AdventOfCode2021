using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilities;

namespace Day06_Lanternfish
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void SimpleFish_Example_Success()
        {
            // Arrange
            int[] intInput = new int[] {3,4,3,1,2};

            // Act
            int outcome = Program.SimpleFish(intInput);

            // Assert
            int expectedOutput = 5934;
            outcome.Should().Be(expectedOutput);
        }

        // [TestMethod]
        // public void SimpleBingo_Exercise_Success()
        // {
        //     // Arrange
        //     string[] stringInput = Utils.Input("day04");
        //     
        //     // Act
        //     int outcome = Program.SimpleBingo(stringInput);
        //
        //     // Assert
        //     int expectedOutput = 46920;
        //     outcome.Should().Be(expectedOutput);
        // }
        //
        [TestMethod]
        public void AdvancedFish_Example_Success()
        {
            // Arrange
            int[] intInput = new int[] {3,4,3,1,2};

            // Act
            long outcome = Program.AdvancedFish(intInput);

            // Assert
            long expectedOutput = 26984457539;
            outcome.Should().Be(expectedOutput);
        }
        //
        // [TestMethod]
        // public void AdvancedBingo_Exercise_Success()
        // {
        //     // Arrange
        //     string[] stringInput = Utils.Input("day04");
        //     
        //     // Act
        //     int outcome = Program.AdvancedBingo(stringInput);
        //
        //     // Assert
        //     int expectedOutput = 12635;
        //     outcome.Should().Be(expectedOutput);
        // }
    }
}