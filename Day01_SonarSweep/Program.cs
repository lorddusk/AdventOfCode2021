using System;

namespace Day01_SonarSweep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] strArray = Utils.ReadInput("day01");
            int[] input = new int[strArray.Length];
            int index = 0;
            foreach (string str in strArray)
            {
                input[index] = int.Parse(strArray[index]);
                ++index;
            }
            Console.WriteLine(string.Format("Part One: {0} measurements are larger than their previous measurement", (object) Program.SimpleScan(input)));
            Console.WriteLine(string.Format("Part Two: {0} measurements are larger than their previous measurement", (object) Program.AdvancedScan(input)));
        }

        public static int SimpleScan(int[] input)
        {
            int num = 0;
            for (int index = 0; index < input.Length; ++index)
            {
                if ((uint) index > 0U && input[index] > input[index - 1])
                    ++num;
            }
            return num;
        }

        public static int AdvancedScan(int[] input)
        {
            int num1 = 0;
            for (int index = 0; index < input.Length; ++index)
            {
                try
                {
                    int num2 = input[index] + input[index + 1] + input[index + 2];
                    if (input[index + 1] + input[index + 2] + input[index + 3] > num2)
                        ++num1;
                }
                catch (IndexOutOfRangeException)
                {
                    break;
                }
            }
            return num1;
        }
    }
}