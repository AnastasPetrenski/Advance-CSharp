using System;
using System.Linq;

namespace _23_TargetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ConvertInputToIntArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] field = new char[rows, cols];

            field = PopulatingFieldWithSnake(field);

            int[] shotArg = ConvertInputToIntArray();

            field = GenerateShotImpact(field, shotArg);

            PrintField(field);
        }

        static char[,] GenerateShotImpact(char[,] field, int[] shotArg)
        {
            int shotRow = shotArg[0];
            int shotCol = shotArg[1];
            int radius = shotArg[2];

            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - shotRow, 2) + Math.Pow(col - shotCol, 2));
                    if (distance <= radius)
                    {
                        field[row, col] = ' ';
                    }
                }
            }

            for (int col = 0; col < field.GetLength(1); col++)
            {
                for (int row = 0; row < field.GetLength(0); row++)
                {
                    if (field[row, col] == ' ')
                    {
                        field = RotateElement(field, col, row);
                    }
                }
            }
            return field;
        }

        static char[,] RotateElement(char[,] field, int col, int i)
        {
            for (int row = i; row > 0; row--)
            {
                var currentElement = field[row, col];
                var nextElement = field[row - 1, col];
                if (nextElement != ' ')
                {
                    field[row, col] = nextElement;
                    field[row - 1, col] = currentElement;
                }
            }
            return field;
        }

        static int[] ConvertInputToIntArray()
        {
            int[] input = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return input;
        }

        static void PrintField(char[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write($"{field[i, j]}");
                }
                Console.WriteLine();
            }
        }

        static char[,] PopulatingFieldWithSnake(char[,] field)
        {
            int index = 0;
            char[] snakeElements = Console
                .ReadLine()
                .ToCharArray();

            bool isDirectionLeft = true;
            for (int row = field.GetLength(0) - 1, col = field.GetLength(1) - 1; row >= 0; row--)
            {

                while (col >= 0 && col < field.GetLength(1))
                {
                    field[row, col] = snakeElements[index];

                    // Change 'col' value
                    col += isDirectionLeft ? -1 : +1;

                    //Change index of snake elements
                    if (index < snakeElements.Length - 1)
                    {
                        index++;
                    }
                    else
                    {
                        index = 0;
                    }
                }

                //Change direction and col value
                col += (isDirectionLeft = !isDirectionLeft) ? -1 : +1;
            }
            return field;
        }
    }
}
