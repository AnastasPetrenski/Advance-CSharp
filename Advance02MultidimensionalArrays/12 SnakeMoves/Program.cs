using System;
using System.Linq;

namespace _12_SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string snake = Console.ReadLine();

            int rows = dimensions[0];
            int cols = dimensions[1];
            var matrix = new char[rows, cols];
            bool isDirectionRight = true;
            int counter = 0;

            for (int row = 0; row < rows; row++)
            {
                if (isDirectionRight)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[counter++];
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }
                    }
                    isDirectionRight = false;
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[counter++];
                        if (counter > snake.Length - 1)
                        {
                            counter = 0;
                        }
                    }
                    isDirectionRight = true;
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
