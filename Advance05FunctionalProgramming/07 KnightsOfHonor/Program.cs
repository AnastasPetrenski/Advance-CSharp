using System;
using System.Linq;

namespace _07_KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> appendSir = (x) => Console.WriteLine($"Sir {x}");

            Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(appendSir);
        }
    }
}
