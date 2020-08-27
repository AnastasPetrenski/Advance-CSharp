using System;
using System.Linq;

namespace _01_SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ConvertInputToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] matrix = new int[rows, cols];
            var rank = matrix.Rank; // rank = 2

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] currentArray = ConvertInputToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentArray[col];
                }
            }

            var currentRows = matrix.GetLength(0);
            Console.WriteLine(currentRows);
            var currentCols = matrix.GetLength(1);
            Console.WriteLine(currentCols);
            long sum = matrix.Cast<int>().Sum();
            Console.WriteLine(sum);
            
        }

        public static int[] ConvertInputToArray()
            =>   Console.ReadLine()
                .Split(new char[] {' ',','}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        
    }
}
