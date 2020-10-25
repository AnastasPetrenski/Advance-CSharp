using System;

namespace ForLoopByRecursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3 };
            Console.WriteLine( Sum(numbers, 0));
        }

        public static int Sum(int [] numbers, int index)
        {
            if (index >= numbers.Length)
            {
                return 0;
            }

            return numbers[index] + Sum(numbers, index + 1);

        }
    }
}
