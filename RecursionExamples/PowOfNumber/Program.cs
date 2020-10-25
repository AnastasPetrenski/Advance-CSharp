using System;

namespace PowOfNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Pow(2, 3));

            Console.WriteLine(Factorial(5));
        }

        private static int Factorial(int v)
        {
            if (v == 1)
            {
                return 1;
            }

            int nextOperator = Factorial(v - 1);

            return v * nextOperator;
        }

        private static int Pow(int x, int n)
        {
            if (n == 1)
            {
                return x;
            }

            int result = x * Pow(x, n - 1);

            return result;
        }
    }
}
