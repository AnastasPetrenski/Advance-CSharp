using System;
using System.Collections.Generic;
using System.Linq;

namespace _10_AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addOneToAllNumbers = x => x + 1;
            Func<int, int> multiplyByTwo = x => x * 2;
            Func<int, int> subtractOneOfAllNumbers = x => x - 1;
            Func<List<int>, string> printNumbers = x => string.Join(" ", x);

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "add")
                {
                    numbers = numbers.Select(addOneToAllNumbers).ToList();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multiplyByTwo).ToList();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractOneOfAllNumbers).ToList();
                }
                else if (command == "print")
                {
                    Console.WriteLine(printNumbers(numbers)); 
                }

                //if (command == "print")
                //{
                //    Console.WriteLine(printNumbers(numbers));
                //}
                //else
                //{
                //    var result = command switch
                //    {
                //        "add" => numbers = numbers.Select(addOneToAllNumbers).ToList(),
                //        "multiply" => numbers = numbers.Select(multiplyByTwo).ToList(),
                //        "subtract" => numbers = numbers.Select(subtractOneOfAllNumbers).ToList(),
                //        _ => numbers,
                //    };
                //}
            }
        }
    }
}
