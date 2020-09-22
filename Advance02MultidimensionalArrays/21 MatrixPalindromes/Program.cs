using System;
using System.Linq;

namespace _21_MatrixPalindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int a = 97 + row;
                char first = (char)a;
                char second = first;

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = $"{first}{second}{first}";
                    second++;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] +" ");
                }
                Console.WriteLine();
            }
        }
    }
}
