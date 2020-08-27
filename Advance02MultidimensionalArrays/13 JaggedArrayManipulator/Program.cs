using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _13_JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            var matrix = new double[rows][];

            for (int row = 0; row < rows; row++)
            {
                double[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                matrix[row] = input;
            }

            for (int row = 0; row < rows - 1; row++)
            {
                if (rows > 1)
                {
                    if (matrix[row].Length == matrix[row + 1].Length)
                    {
                        matrix[row] = matrix[row].Select(x => x *= 2).ToArray();
                        matrix[row + 1] = matrix[row + 1].Select(x => x *= 2).ToArray();
                    }
                    else
                    {
                        matrix[row] = matrix[row].Select(x => x /= 2).ToArray();
                        matrix[row + 1] = matrix[row + 1].Select(x => x /= 2).ToArray();
                    }
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                List<string> commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                if (commands[0] == "Add")
                {
                    if (row >= 0 && row < matrix.GetLength(0) &&
                        col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] += value; 
                    }
                }
                else if (commands[0] == "Subtract")
                {
                    if (row >= 0 && row < matrix.GetLength(0) &&
                        col >= 0 && col < matrix[row].Length)
                    {
                        matrix[row][col] -= value;
                    }
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join(" ", item));
            }
        }
    }
}
