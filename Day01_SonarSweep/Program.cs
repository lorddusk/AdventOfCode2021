using System;
using StringUtilities;

namespace Day01_SonarSweep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day01");
            int[] input = Utils.StringToIntArray(stringInput);

            int output = SimpleScan(input);
            Console.WriteLine($"Part One: {output} measurements are larger than their previous measurement.");
            output = AdvancedScan(input);
            Console.WriteLine($"Part Two: {output} measurements are larger than their previous measurement.");
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