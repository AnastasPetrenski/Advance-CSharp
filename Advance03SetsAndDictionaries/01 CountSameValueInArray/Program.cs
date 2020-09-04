using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_CountSameValueInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> appearanceCounter = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!appearanceCounter.ContainsKey(numbers[i]))
                {
                    appearanceCounter.Add(numbers[i], 0);
                }

                appearanceCounter[numbers[i]]++;
            }

            foreach (var (key, value) in appearanceCounter)
            {
                Console.WriteLine($"{key} - {value} times");
            }
        }
    }
}
