/*Write a program that read a matrix from console. Then find biggest sum of 2x2 submatrix and print it to console.
On first line you will get matrix sizes in format rows, columns.
One next rows lines you will get elements for each column separated with coma.
Print biggest top-left square, which you find and sum of its elements.
Examples:
Input	
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0	
Output
9 8
7 9
33
 */

using System;
using System.Data.SqlTypes;
using System.Linq;

namespace _02_SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ConvertInputToArray(',', ' ');
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];
            
            for (int row = 0; row < rows; row++)
            {
                int[] currArr = ConvertInputToArray(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currArr[col];
                }
            }

            for (int col = 0; col < matrix.GetLongLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLongLength(0); row++)
                {
                    sum += matrix[row, col];
                }
                Console.WriteLine(sum);
            }

        }

        
        public static int[] ConvertInputToArray(params char[] separators)
        =>   Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
