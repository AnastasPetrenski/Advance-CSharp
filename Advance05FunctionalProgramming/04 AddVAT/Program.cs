using System;
using System.Linq;

namespace _04_AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console
                .ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList()
                .ForEach(x => Console.WriteLine($"{x*1.2:f2}"));
        }
    }
}
