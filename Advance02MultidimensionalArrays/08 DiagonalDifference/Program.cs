using System;
using System.Linq;

namespace _08_DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] arr = ConvertInputToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];
                }
            }

            int primeDiagonal = 0;
            for (int row = 0; row < n; row++)
            {
                for (int col = row; col < n; col++)
                {
                    primeDiagonal += matrix[row, col];
                    break;
                }
            }

            int secondaryDiagonal = 0;
            for (int row = n-1; row >= 0; row--)
            {
                for (int col = n-1 - row; col < n; col++)
                {
                    secondaryDiagonal += matrix[row, col];
                    break;
                }
            }

            int diff = Math.Abs(primeDiagonal - secondaryDiagonal);
            Console.WriteLine(diff);
        }

        public static int[] ConvertInputToArray()
            => Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
    }
}
