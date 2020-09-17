using System;
using System.Linq;

namespace _02_SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console
                .ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Console.WriteLine(list.Count);
            Console.WriteLine(list.Sum());
        }
    }
}
