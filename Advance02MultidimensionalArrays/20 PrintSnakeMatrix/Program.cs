using System;

namespace _20_PrintSnakeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());

            int[,] matrix = new int[dimensions, dimensions];
            int count = 1;
            string direction = "right";
            int row = 0;
            int col = -1;

            for (int i = 0; i < dimensions * dimensions; i++)
            {
                bool isCountIncrement = false;

                if (direction == "right" )
                {
                    if (col < matrix.GetLength(1) - 1 && matrix[row, col+1] == 0)
                    {
                        col++;
                        matrix[row, col] = count;
                        isCountIncrement = true;
                    }
                    else
                    {
                        direction = "down";
                    }
                    
                }

                if (direction == "down")
                {
                    if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] == 0)
                    {
                        row++;
                        matrix[row, col] = count;
                        isCountIncrement = true;
                    }
                    else
                    {
                        direction = "left";
                    }
                }

                if (direction == "left")
                {
                    if (col > 0 && matrix[row, col - 1] == 0)
                    {
                        col--;
                        matrix[row, col] = count;
                        isCountIncrement = true;
                    }
                    else
                    {
                        direction = "up";
                    }
                }

                if (direction == "up" )
                {
                    if (row > 0 && matrix[row-1, col] == 0)
                    {
                        row--;
                        matrix[row, col] = count;
                        isCountIncrement = true;
                    }
                    else
                    {
                        direction = "right";
                    }
                }

                if (isCountIncrement)
                {
                    count++;
                }
                else
                {
                    i--;
                }
                
            }

            //Console.WriteLine($"{row}, {col} - {matrix[row, col]}" );
            for (int k = 0; k < dimensions; k++)
            {
                for (int h = 0; h < dimensions; h++)
                {
                    Console.Write(matrix[k, h] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
