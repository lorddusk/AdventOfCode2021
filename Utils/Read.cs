using System.IO;

namespace Utils
{
    public class Read
    {
        public static string[] Input(string day)
        {
            return File.ReadAllLines($@"F:\.NET\AOC2021\AdventOfCode\Inputs\{day}.txt");
        }

        public static int[] StringToIntArray(string[] input)
        {
            int[] output = new int[input.Length];
            int index = 0;
            foreach (string str in input)
            {
                output[index] = int.Parse(input[index]);
                ++index;
            }

            return output;
        }
    }
}