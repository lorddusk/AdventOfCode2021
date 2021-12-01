using System.IO;

namespace Day01_SonarSweep
{
    public class Utils
    {
        public static string[] ReadInput(string day)
        {
            return File.ReadAllLines($@"F:\.NET\AOC2021\AdventOfCode\Inputs\{day}.txt");
        }
    }
}