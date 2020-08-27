using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse);
            Queue<int> numbers = new Queue<int>(input);
            Queue<int> evens = new Queue<int>();
            while (numbers.Any())
            {
                var currNum = numbers.Dequeue();
                if (currNum % 2 == 0)
                {
                    evens.Enqueue(currNum);
                }
            }

            Console.WriteLine(string.Join(", ", evens));
        }
    }
}
