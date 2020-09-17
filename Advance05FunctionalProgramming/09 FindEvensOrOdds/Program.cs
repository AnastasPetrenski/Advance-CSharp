using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            var boundary = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int startBoundary = boundary[0];
            int endBoundary = boundary[1];
            
            var type = Console.ReadLine();
            List<int> result = new List<int>();
            Predicate<int> isEven = x => x % 2 == 0;

            Enumerable.Range(startBoundary, (endBoundary - startBoundary) + 1)
                    .Where(x => type == "even" ? isEven(x) : !isEven(x))
                    .ToList()
                    .ForEach(result.Add);
                
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
