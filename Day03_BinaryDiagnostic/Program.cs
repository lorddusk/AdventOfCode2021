using System;
using System.Collections.Generic;
using System.Linq;
using StringUtilities;

namespace Day03_BinaryDiagnostic
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day03");

            (int gamma, int epsilon) = SimpleDiagnostic(stringInput);
            Console.WriteLine($"Part One: {gamma * epsilon} power consumption.");
            (int oxygen, int co2) = AdvancedDiagnostic(stringInput);
            Console.WriteLine($"Part Two: {oxygen * co2} life support rating.");
        }

        public static (int, int) SimpleDiagnostic(string[] input)
        {
            var gammaS = "";
            for (int i = 0; i < input[0].Length; i++)
            {
                int one = 0;
                int zero = 0;
                foreach (string line in input)
                {
                    if (line[i].ToString().Equals("0"))
                        zero++;
                    else
                        one++;
                }

                if (zero > one)
                    gammaS += "0";
                else
                    gammaS += "1";
            }

            var epsilonS = "";
            for (int i = 0; i < input[0].Length; i++)
            {
                int one = 0;
                int zero = 0;
                foreach (string line in input)
                {
                    if (line[i].ToString().Equals("0"))
                        zero++;
                    else
                        one++;
                }

                if (zero > one)
                    epsilonS += "1";
                else
                    epsilonS += "0";
            }

            return (Utils.BinaryToDecimal(gammaS), Utils.BinaryToDecimal(epsilonS));
        }

        public static (int, int) AdvancedDiagnostic(string[] input)
        {
            string oxygen = GetOxygen(input);

            string co2 = GetCO2(input);

            return (Utils.BinaryToDecimal(oxygen), Utils.BinaryToDecimal(co2));
        }

        private static string GetOxygen(string[] input)
        {
            string[] currentInput = input;
            int position = 0;
            while (currentInput.Length > 1)
            {

                (int one, int zero) = DetermineZeroOrOne(currentInput, position);

                List<string> tempOutput = new List<string>();
                foreach (string line in currentInput)
                {
                    if (zero > one)
                    {
                        if (line[position].ToString().Equals("0"))
                        {
                            tempOutput.Add(line);
                        }
                    }
                    else
                    {
                        if (line[position].ToString().Equals("1"))
                        {
                            tempOutput.Add(line);
                        }
                    }
                }

                currentInput = tempOutput.ToArray();

                position++;
            }

            return currentInput[0];
        }

        private static string GetCO2(string[] input)
        {
            string[] currentInput = input;
            int position = 0;
            while (currentInput.Length > 1)
            {

                (int one, int zero) = DetermineZeroOrOne(currentInput, position);

                List<string> tempOutput = new List<string>();
                foreach (string line in currentInput)
                {
                    if (zero <= one)
                    {
                        if (line[position].ToString().Equals("0"))
                        {
                            tempOutput.Add(line);
                        }
                    }
                    else
                    {
                        if (line[position].ToString().Equals("1"))
                        {
                            tempOutput.Add(line);
                        }
                    }
                }

                currentInput = tempOutput.ToArray();

                position++;
            }

            return currentInput[0];
        }
        
        private static (int,int) DetermineZeroOrOne(string[] currentInput, int position)
        {
            int one = 0;
            int zero = 0;
            foreach (string line in currentInput)
            {
                if (line[position].ToString().Equals("0"))
                    zero++;
                else
                    one++;
            }

            return (one, zero);
        }
    }
}