using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05_SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = {' ', ','};
            int[] dimensions = ParseInputToArray(separators);

            var matrix = new int[dimensions[0], dimensions[1]];

            for (int rows = 0; rows < dimensions[0]; rows++)
            {
                int[] input = ParseInputToArray(separators);
                for (int j = 0; j < dimensions[1]; j++)
                {
                    matrix[rows, j] = input[j];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] +
                              matrix[row, col + 1] +
                              matrix[row + 1, col] +
                              matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }

                }
            }

            Console.WriteLine($"{matrix[maxRow, maxCol]} {matrix[maxRow, maxCol + 1]}");
            Console.WriteLine($"{matrix[maxRow + 1, maxCol]} {matrix[maxRow + 1, maxCol + 1]}");
            Console.WriteLine(maxSum);
        }

        public static int[] ParseInputToArray(params char[] separators)
             => Console.ReadLine()
                .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    }
}
