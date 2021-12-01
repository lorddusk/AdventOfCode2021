using System.IO;

namespace Utils
{
    public class Read
    {
        public static string[] Input(string day)
        {
            return File.ReadAllLines($@"F:\.NET\AOC2021\AdventOfCode\Inputs\{day}.txt");
        }
    }
}