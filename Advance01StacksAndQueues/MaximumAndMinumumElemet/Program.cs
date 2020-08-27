using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinumumElemet
{
    class Program
    {
        static void Main(string[] args)
        {
            int queryNumbers = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;
            for (int i = 0; i < queryNumbers; i++)
            {
                List<int> commands = Console.ReadLine().Split().Select(int.Parse).ToList();
                int command = commands[0];
                if (command == 1)
                {
                    numbers.Push(commands[1]);
                }
                else if (command == 2)
                {
                    if (numbers.Any())
                    {
                        numbers.Pop();
                    }
                }
                else if (command == 3)
                {
                    if (numbers.Any())
                    {
                        foreach (var item in numbers)
                        {
                            if (item > maxNum)
                            {
                                maxNum = item;
                            }
                        }
                        Console.WriteLine(maxNum);
                    }
                }
                else if (command == 4)
                {
                    if (numbers.Any())
                    {
                        foreach (var item in numbers)
                        {
                            if (item < minNum)
                            {
                                minNum = item;
                            }
                        }
                        Console.WriteLine(minNum);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
