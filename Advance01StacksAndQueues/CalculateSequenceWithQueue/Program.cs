using System;
using System.Collections;
using System.Collections.Generic;

namespace CalculateSequenceWithQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<long> numbers = new List<long>();
            numbers.Add(number);
            long x = number;
            for (long i = 0, s = 0, t = 1; i < 50 - 1; i++, t++)
            {
                s = (x + 1);
                numbers.Add(s);
                s = (2 * x + 1);
                numbers.Add(s);
                s = (x + 2);
                numbers.Add(s);
                x = numbers[(int)t];
                i += 2;
            }

            for (int d = 0; d < 50; d++)
            {
                Console.Write(numbers[d] + " ");
            }
        }
    }
}
