using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_TriFunctionClassicSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split()
                .ToList();
            //Func<name, target, boolean>
            Func<string, int, bool> calculation = (a, b) => a.Sum(c => c) >= b;
            Func<Func<string, int, bool>, List<string>, string> findTheBiggestName = (a, b) => b.FirstOrDefault(s => a(s, target));

            string output = findTheBiggestName(calculation, names);

            if (output.Length > 0)
            {
                Console.WriteLine(output);
            }
        }
    }
}
