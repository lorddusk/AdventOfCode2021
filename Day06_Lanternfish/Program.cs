using System;
using System.Collections.Generic;
using System.Linq;
using Day06_Lanternfish.Models;
using StringUtilities;

namespace Day06_Lanternfish
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringInput = Utils.Input("day06");
            int[] input = Utils.StringToIntArray(stringInput[0].Split(','));

            dynamic output = SimpleFish(input);
            Console.WriteLine($"Part One: There are {output} lanternfish after 80 days.");
            output = AdvancedFish(input);
            Console.WriteLine($"Part Two: There are {output} lanternfish after 256 days.");
        }

        public static int SimpleFish(int[] input, int days = 80)
        {
            List<Fish> fishes = new List<Fish>();
            foreach (int current in input)
            {
                fishes.Add(new Fish(current));
            }

            for (int i = 0; i < days; i++)
            {
                List<Fish> newFishes = new List<Fish>();
                foreach (Fish fish in fishes)
                {
                    if (fish.TimeToNewFish == 0)
                    {
                        fish.TimeToNewFish = 6;
                        Fish newFish = new Fish(8);
                        newFishes.Add(newFish);
                    }
                    else
                    {
                        fish.TimeToNewFish--;
                    }
                }
                fishes.AddRange(newFishes);
            }

            return fishes.Count;
        }

        public static long AdvancedFish(int[] input, int days = 256)
        {
            Dictionary<long, long> fishes = new Dictionary<long, long>();
            foreach (int current in input)
            {
                CheckDictionaryForFish(fishes, current, 1);
            }

            for (int i = 0; i < days; i++)
            {
                Dictionary<long, long> nextDayFish = new Dictionary<long, long>();

                foreach (long day in fishes.Keys.ToArray())
                {
                    long amountOfFishToday = fishes[day];
                    long amountOfFishTomorrow = day - 1;

                    if (amountOfFishTomorrow >= 0)
                    {
                        CheckDictionaryForFish(nextDayFish, amountOfFishTomorrow, amountOfFishToday);
                    }
                    else
                    {
                        CheckDictionaryForFish(nextDayFish, 8, amountOfFishToday);
                        CheckDictionaryForFish(nextDayFish, 6, amountOfFishToday);
                    }
                }

                fishes = nextDayFish;
            }

            long sum = 0;
            foreach (long value in fishes.Values)
            {
                sum += value;
            }
            
            return sum;
        }

        public static void CheckDictionaryForFish(Dictionary<long, long> dictionary, long fish, long amountOfFish)
        {
            if (dictionary.ContainsKey(fish))
            {
                dictionary[fish] += amountOfFish;
            }
            else
            {
                dictionary.Add(fish, amountOfFish);
            }
        }
    }
}