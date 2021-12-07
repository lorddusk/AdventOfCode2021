using System;
using StringUtilities;

namespace Day05_HydrothermalVenture
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day05");

            int outcome = 0;
            SimpleProgram(stringInput);
            Console.WriteLine($"Part One: {outcome}.");
            AdvancedProgram(stringInput);
            Console.WriteLine($"Part Two: {outcome}.");
        }

        public static void SimpleProgram(string[] input)
        {
        }

        public static void AdvancedProgram(string[] input)
        {
        }
    }
}