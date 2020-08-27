using System;
using System.Linq;

namespace _03_PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] separators = { ' ', ',' };
            int dimensions = int.Parse(Console.ReadLine());

            var matrix = new int[dimensions, dimensions];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] arr = ParseInputToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int primeDiagonalSum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = row; col < matrix.GetLength(1); col++)
                {
                    primeDiagonalSum += matrix[row, col];
                    break;
                }
            }

            Console.WriteLine(primeDiagonalSum);
        }

        public static int[] ParseInputToArray(params char[] separators)
        => Console.ReadLine()
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
    
}
