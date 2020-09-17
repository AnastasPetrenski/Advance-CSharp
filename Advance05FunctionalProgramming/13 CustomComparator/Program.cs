using System;
using System.Collections.Generic;
using System.Linq;

namespace _13_CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
                var array = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

            Func<int, int, int> comparer = (x, y) =>

            Math.Abs(x % 2) == Math.Abs(y % 2) ? 
            (x == y ? x.CompareTo(y) : (x < y ? -1 : 1)) : 
            (Math.Abs(x % 2) == 0 ? -1 : 1);

            Array.Sort(array, (x, y) => comparer(x, y));

            Console.WriteLine(String.Join(" ", array));
        }
    }
}
