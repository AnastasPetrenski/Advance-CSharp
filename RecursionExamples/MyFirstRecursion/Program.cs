using System;

namespace MyFirstRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumbers(10);
        }

        public static void PrintNumbers(int n)
        {
            if (n == 0)
            {
                return;
            }
            Console.WriteLine(n);
            PrintNumbers(n - 1);
            
        }
    }
}
