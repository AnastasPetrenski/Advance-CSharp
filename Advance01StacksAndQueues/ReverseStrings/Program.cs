using System;
using System.Collections.Generic;
using System.Linq;

namespace ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var reversed = new Stack<char>(Console.ReadLine());
            var newCollection = new Stack<char>();
            while (reversed.Any())
            {
                var current = reversed.Pop();
                newCollection.Push(current);
                Console.Write(current);
            }
            Console.WriteLine();
            Console.WriteLine("----Out of the while-----");
            Console.WriteLine(string.Join("", newCollection));
        }
    }
}
