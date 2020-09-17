using System;
using System.Collections.Generic;
using System.Linq;

namespace _11_ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse);

            int operand = int.Parse(Console.ReadLine());

            //Func<List<int>, List<int>> filterList = x => x.Where(x => x % operand != 0).Reverse().ToList();
            //numbers = filterList(numbers);

            Func<int, bool> filterNumber = x => x % operand != 0;
            numbers = numbers.Where(filterNumber)
                .Reverse();

            Action<IEnumerable<int>> printNumbers = x => Console.WriteLine(string.Join(" ", x));

            printNumbers(numbers);

        }
    }
}
