using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseNumbersWithStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
