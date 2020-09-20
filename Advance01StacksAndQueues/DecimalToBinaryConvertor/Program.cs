using System;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Stack<int> binary = new Stack<int>();

            while (number > 0)
            {
                binary.Push(number % 2);
                number /= 2;
            }

            List<int> print = new List<int>(binary);
            Console.WriteLine(string.Join("", print));
        }
    }
}
