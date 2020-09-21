using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>(
                Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList());

            Dictionary<int, List<int>> grouping = new Dictionary<int, List<int>>();

            foreach (var number in numbers)
            {
                if (Math.Abs(number) % 3 == 0)
                {
                    if (!grouping.ContainsKey(0))
                    {
                        grouping.Add(0, new List<int>());
                        grouping[0].Add(number);
                    }
                    else
                    {
                        grouping[0].Add(number);
                    }
                }
                else if (Math.Abs(number) % 3 == 1)
                {
                    if (!grouping.ContainsKey(1))
                    {
                        grouping.Add(1, new List<int>());
                        grouping[1].Add(number);
                    }
                    else
                    {
                        grouping[1].Add(number);
                    }
                }
                if (Math.Abs(number) % 3 == 2)
                {
                    if (!grouping.ContainsKey(2))
                    {
                        grouping.Add(2, new List<int>());
                        grouping[2].Add(number);
                    }
                    else
                    {
                        grouping[2].Add(number);
                    }
                }
            }

            foreach (var group in grouping.OrderBy(x => x.Key))
            {
                Console.WriteLine(string.Join(" ", group.Value));
            }
        }
    }
}
