using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _11_MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                List<string> commands = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (commands[0] == "swap" && commands.Count == 5)
                {
                    int rowFirst = int.Parse(commands[1]);
                    int colFirst = int.Parse(commands[2]);
                    int rowSecond = int.Parse(commands[3]);
                    int colSecond = int.Parse(commands[4]);

                    if ((rowFirst >= 0 && rowFirst < matrix.GetLength(0)) &&
                        (colFirst >= 0 && colFirst < matrix.GetLength(1)) &&
                        (rowSecond >= 0 && rowSecond < matrix.GetLength(0)) &&
                        (colSecond >= 0 && colSecond < matrix.GetLength(1)))
                    {
                        var temp = matrix[rowFirst, colFirst];
                        matrix[rowFirst, colFirst] = matrix[rowSecond, colSecond];
                        matrix[rowSecond, colSecond] = temp;

                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                Console.Write($"{matrix[row, col]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
