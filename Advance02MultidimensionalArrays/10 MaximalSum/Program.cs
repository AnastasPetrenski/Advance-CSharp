using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _10_MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensionals = ParseInputToArray();
            int rows = dimensionals[0];
            int cols = dimensionals[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] temp = ParseInputToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = temp[col];
                }
            }

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int count = 0;
                    int sum = 0;
                    int numeric = 0;
                    int x = row;
                    int y = col;
                    while (numeric < 9)
                    {   
                        if (count < 3)
                        {
                            sum += matrix[x, y];
                            y++;
                            count++;
                        }
                        else
                        {
                            x++;
                            y = col;
                            count = 0;
                            continue;
                        }
                        numeric++;
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int j = 1,row = maxRow; j <= 3; row++, j++)
            {
                for (int i = 1, col = maxCol; i <= 3; col++, i++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int[] ParseInputToArray()
            => Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
    }
}
