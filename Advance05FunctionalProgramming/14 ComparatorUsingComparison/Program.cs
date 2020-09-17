using System;
using System.Linq;

namespace _13_ComparatorUsingComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> comparator = (x, y) =>
            {
                if (x % 2 == 0 && y % 2 != 0)
                {
                    return -1;
                }
                else if (x % 2 != 0 && y % 2 == 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                    //return x.CompareTo(y); - sort in ascending order
                }
            };

            Comparison<int> comparison = new Comparison<int>(comparator);

            var array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Array.Sort(array, comparison);

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
