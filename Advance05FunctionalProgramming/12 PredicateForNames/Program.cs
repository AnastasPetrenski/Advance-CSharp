using System;
using System.Linq;

namespace _12_PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthName = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Predicate<string> name = x => x.Length <= lengthName;
            Func<string, bool> filterNameByLength = x => name(x);

            names = names
                .Where(filterNameByLength)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
