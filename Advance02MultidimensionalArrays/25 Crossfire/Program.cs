using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Linq;

namespace _25_Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = ReadInput();

            int[,] matrix = GenerateMatrix(dimensions);
            PrintMatrix(matrix);
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Nuke it from orbit")
            {
                int[] commands = ReadInput(command);

                RemoveAffectedFields(commands, matrix);

                RearrangeMatrix(matrix);

                CheckForEmptyRowsAndRemoveThem(matrix);
            }

            PrintMatrix(matrix);
        }

        static int[,] CheckForEmptyRowsAndRemoveThem(int[,] matrix)
        {
            List<int> emptyRowsIndexes = new List<int>();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    // if you find non-empty element go to next row
                    if (matrix[i, j] != 0)
                    {
                        break;
                    }

                    // if that's the last element and it's 0, then the row is empty, save the index
                    if (j == matrix.GetLength(1) - 1 && matrix[i, j] == 0)
                    {
                        emptyRowsIndexes.Add(i);
                    }
                }
            }

            if (emptyRowsIndexes.Count == 0)
            {
                return matrix;
            }
            else
            {
                int reducedMatrixrows = matrix.GetLength(0) - emptyRowsIndexes.Count;
                int reducedMatrixCols = matrix.GetLength(1);
                int[,] reducedMatrix = new int[reducedMatrixrows, reducedMatrixCols];

                int reducedMatrixRow = 0;
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (emptyRowsIndexes.Contains(i))
                    {
                        continue;
                    }

                    int reducedMatrixCol = 0;
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        reducedMatrix[reducedMatrixRow, reducedMatrixCol] = matrix[i, j];
                        reducedMatrixCol++;
                    }

                    reducedMatrixRow++;
                }

                return reducedMatrix;
            }
        }
    
        static int[,] RearrangeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        RotatingElement(row, col, matrix);
                    }
                }
            }

            return matrix;
        }

        static int[,] RotatingElement(int row, int i, int[,] matrix)
        {
            if (i + 1 < matrix.GetLength(1))
            {
                for (int col = i; col < matrix.GetLength(1); col++)
                {
                    matrix[row, i] = matrix[row, i + 1];
                }
                matrix[row, matrix.GetLength(1) - 1] = 0;
            }

            return matrix;
            
        }

        private static bool CheckOutOfRange(int[,] matrix, int row, int col)
        {
            if (row < 0 || row >= matrix.GetLength(0))
            {
                return false;
            }
            
            if (col < 0 || col >= matrix.GetLength(1))
            {
                return false;
            }

            return true;
        }

        static int[,] RemoveAffectedFields(int[] commands, int[,] matrix)
        {
            int row = commands[0];
            int col = commands[1];
            int radius = commands[2];

            if (CheckOutOfRange(matrix, row, col))
            {
                matrix[row, col] = 0;
            }
            

            //up
            for (int i = 1; i <= radius; i++)
            {
                if (CheckOutOfRange(matrix, row - i, col))
                {
                    matrix[row - i, col] = 0;
                }
            }
            //down
            for (int i = 1; i <= radius; i++)
            {
                if (CheckOutOfRange(matrix, row + i, col))
                {
                    matrix[row + i, col] = 0;
                }
            }
            //left 
            for (int i = 1; i <= radius; i++)
            {
                if (CheckOutOfRange(matrix, row, col - i))
                {
                    matrix[row, col - i] = 0;
                }
            }
            //right
            for (int i = 1; i <= radius; i++)
            {
                if (CheckOutOfRange(matrix, row, col + i))
                {
                    matrix[row, col + i] = 0;
                }
            }

            return matrix;
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write(" " + " ");
                    }
                    else
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    
                }
                Console.WriteLine();
            }
        }

        static int[,] GenerateMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];
            int counter = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = counter++; 
                }
            }

            return matrix;
        }

        static int[] ReadInput()
            => Console
            .ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        static int[] ReadInput(string input)
            => input
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
    }
}
