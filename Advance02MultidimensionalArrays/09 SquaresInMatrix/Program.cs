using System;
using System.Linq;

namespace _09_SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ParseInputToArray();

            char[,] matrix = new char[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {   
                char[] current = CharParseInputToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = current[col];
                }
            }

            int counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] 
                        && matrix[row, col + 1] == matrix[row + 1, col] 
                        && matrix[row + 1, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        public static int[] ParseInputToArray()
            => Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

        public static char[] CharParseInputToArray()
            => Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(char.Parse)
            .ToArray();
    }
}
