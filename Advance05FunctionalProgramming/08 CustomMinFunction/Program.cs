using System;
using System.Linq;

namespace _08_CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<int[], int> fingMinValue = x => x.Min();
            Func<int[], int> findMinValue = GetMinValue;
            var numbers = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine(findMinValue(numbers)); 

        }

        public static int GetMinValue(int[] numbers)
        {
            int minNumber = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minNumber)
                {
                    minNumber = numbers[i];
                }
            }

            return minNumber;
        }
    }
}
