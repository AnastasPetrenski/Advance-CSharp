using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] setsLenght = ConvertInputToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();
            for (int i = 0; i < setsLenght.Length; i++)
            {
                for (int j = 0; j < setsLenght[i]; j++)
                {
                    int input = int.Parse(Console.ReadLine());
                    if (i == 0)
                    {
                        firstSet.Add(input);
                    }
                    else
                    {
                        secondSet.Add(input);
                    }
                }
            }

            firstSet.IntersectWith(secondSet);
            Console.WriteLine(string.Join(" ", firstSet));
        }

        public static int[] ConvertInputToArray()
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return arr;
        }
    }
}
