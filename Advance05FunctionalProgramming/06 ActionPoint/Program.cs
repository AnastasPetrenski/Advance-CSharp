using System;
using System.Linq;

namespace _06_ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> writer = (x) => Console.WriteLine(x);

            Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(writer);
        }
    }
}
