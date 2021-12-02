using System;
using Utils;

namespace Day02_Dive
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] stringInput = Read.Input("day02");

            (int horizontal, int depth) = SimpleMove(stringInput);
            Console.WriteLine($"Part One: {horizontal * depth} horizontal * depth.");
            (horizontal, depth) = AdvancedMove(stringInput);
            Console.WriteLine($"Part Two: {horizontal * depth} horizontal * depth.");
        }

        public static (int, int) SimpleMove(string[] input)
        {
            int horizontal = 0;
            int depth = 0;
            foreach (string line in input)
            {
                string[] splittedLine = line.Split(" ");
                switch (splittedLine[0])
                {
                    case "forward":
                        horizontal += int.Parse(splittedLine[1]);
                        break;
                    case "up":
                        depth -= int.Parse(splittedLine[1]);
                        break;
                    case "down":
                        depth += int.Parse(splittedLine[1]);
                        break;
                }
            }

            return (horizontal, depth);
        }

        public static (int, int) AdvancedMove(string[] input)
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;
            
            foreach (string line in input)
            {
                string[] splittedLine = line.Split(" ");
                switch (splittedLine[0])
                {
                    case "forward":
                        horizontal += int.Parse(splittedLine[1]);
                        depth += aim * int.Parse(splittedLine[1]);
                        break;
                    case "up":
                        aim -= int.Parse(splittedLine[1]);
                        break;
                    case "down":
                        aim += int.Parse(splittedLine[1]);
                        break;
                }
            }

            return (horizontal, depth);
        }
    }
}