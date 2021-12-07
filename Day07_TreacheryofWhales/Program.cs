using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Xml.Linq;
using StringUtilities;

namespace Day07_TreacheryofWhales
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day07");
            int[] input = Utils.StringToIntArray(stringInput[0].Split(","));

            int outcome = 0;
            outcome = SimpleProgram(input);
            Console.WriteLine($"Part One: {outcome}.");
            AdvancedProgram(input);
            Console.WriteLine($"Part Two: {outcome}.");
        }

        public static int SimpleProgram(int[] input)
        {
            Array.Sort(input);
            int first = input[0];
            int last = input[input.Length-1];
            Dictionary<int, int> positionFuel = new Dictionary<int, int>();

            for (int pos = first; pos < last; pos++)
            {
                foreach (int crab in input)
                {
                    int cost = crab - pos;
                    cost = Math.Abs(cost);
                    DictionaryFuelCost(positionFuel, pos, cost);
                }
            }

            var list = positionFuel.ToList();
            list.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            return list[0].Value;
        }

        public static int AdvancedProgram(int[] input)
        {
            Array.Sort(input);
            int first = input[0];
            int last = input[input.Length-1];
            Dictionary<int, int> positionFuel = new Dictionary<int, int>();

            for (int pos = first; pos < last; pos++)
            {
                foreach (int crab in input)
                {
                    int fuelCost = 0;
                    int difference = Math.Abs(crab - pos);
                    for (int i = 1; i <= difference; i++)
                    {
                        fuelCost += (1 * i);
                    }
                    DictionaryFuelCost(positionFuel, pos, fuelCost);
                }
            }

            var list = positionFuel.ToList();
            list.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            return list[0].Value;
        }
        
        public static void DictionaryFuelCost(Dictionary<int, int> dictionary, int position, int fuelCost)
        {
            if (dictionary.ContainsKey(position))
            {
                dictionary[position] += fuelCost;
            }
            else
            {
                dictionary.Add(position, fuelCost);
            }
        }
    }
}