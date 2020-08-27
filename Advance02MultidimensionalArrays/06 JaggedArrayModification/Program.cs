using System;
using System.Data;
using System.Linq;

namespace _06_JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = ParseInputToArray();
                matrix[row] = input;
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                var commands = ParseInputToArray(command);
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);
                int dimensionsRow = matrix.GetLength(0);
                int dimensionsCol = matrix.GetLength(1);
                if ((row >= 0 && row < matrix.GetLength(0)) && (col >= 0 && col < matrix[row].Length))
                {
                    if (commands.Contains("Add"))
                    {
                        matrix[row][col] += value;  
                    }
                    else if (commands.Contains("Subtract"))
                    {
                        matrix[row][col] -= value;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }

            //Console.WriteLine(string.Join(Environment.NewLine, matrix.Select(curRow => string.Join(" ", curRow))));

            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

            
        }

        public static int[] ParseInputToArray()
            => Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

        public static string[] ParseInputToArray(string command)
            =>   command
                .Split()
                .ToArray();
    }
}
