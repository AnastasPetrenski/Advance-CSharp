using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace _01_SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine(string.Join(", ", Console
                .ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Where(x => x % 2 == 0)
                .OrderBy(x => x)
                .ToList()));
        }
    }
}
