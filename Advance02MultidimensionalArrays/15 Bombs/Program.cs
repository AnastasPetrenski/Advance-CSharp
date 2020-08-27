using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _15_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            var field = new int[dimensions, dimensions];

            PopulatedField(field, dimensions);
            
            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            Dictionary<int, List<int>> bombCoordinate = new Dictionary<int, List<int>>();

            for (int i = 0; i < bombs.Length; i++)
            {
                string bomb = bombs[i];
                var row = bomb[0] - '0';
                var col = bomb[2] - '0';
                var value = field[row, col];

                if (value <= 0)
                {
                    continue;
                }

                if (row - 1 >= 0 && col - 1 >= 0)
                {
                    if (field[row - 1, col - 1] > 0)
                    {
                        field[row - 1, col - 1] -= value;
                    }
                }

                if (row - 1 >= 0)
                {
                    if (field[row - 1, col] > 0)
                    {
                        field[row - 1, col] -= value;
                    }
                }

                if (row - 1 >= 0 && col + 1 < dimensions)
                {
                    if (field[row - 1, col + 1] > 0)
                    {
                        field[row - 1, col + 1] -= value;
                    }
                }

                if (col - 1 >= 0)
                {
                    if (field[row, col - 1] > 0)
                    {
                        field[row, col - 1] -= value;
                    }
                }

                if (col + 1 < dimensions)
                {
                    if (field[row, col + 1] > 0)
                    {
                        field[row, col + 1] -= value;
                    }
                }

                if (row + 1 < dimensions && col - 1 >= 0)
                {
                    if (field[row + 1, col - 1] > 0)
                    {
                        field[row + 1, col - 1] -= value;
                    }
                }

                if (row + 1 < dimensions)
                {
                    if (field[row + 1, col] > 0)
                    {
                        field[row + 1, col] -= value;
                    }
                }

                if (row + 1 < dimensions && col + 1 < dimensions)
                {
                    if (field[row + 1, col + 1] > 0)
                    {
                        field[row + 1, col + 1] -= value;
                    }
                }

                field[row, col] = 0;
                bombCoordinate.Add(i, new List<int>());
                bombCoordinate[i].Add(row);
                bombCoordinate[i].Add(col);
            }

            for (int i = 0; i < bombCoordinate.Count; i++)
            {
                var first = bombCoordinate[i][0];
                var second = bombCoordinate[i][1];
                field[first, second] = 0;
            }


            int alive = 0;
            int sum = 0;
            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    if (field[row, col] > 0)
                    {
                        alive++;
                        sum += field[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {alive}");
            Console.WriteLine($"Sum: {sum}");

            
            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    Console.Write($"{field[row, col]} ");
                }
                Console.WriteLine();
            }
        }

        public static int[,] PopulatedField(int[,] field, int dimensions)
        {
            for (int row = 0; row < dimensions; row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < dimensions; col++)
                {
                    field[row, col] = input[col];
                }
            }

            return field;
        }
    }
}
