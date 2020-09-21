using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int command = input[0];
                if (command == 1)
                {
                    numbers.Push(input[1]);
                }
                else if (command == 2)
                {
                    numbers.Pop();
                }
                else if (command == 3)
                {
                    PrintMaxNumber(numbers);
                }
            }
        }

        static void PrintMaxNumber(Stack<int> numbers)
        {
            int max = int.MinValue;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine(max);
        }
    }
}
