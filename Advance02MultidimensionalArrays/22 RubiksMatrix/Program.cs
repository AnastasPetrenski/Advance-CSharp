using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            int[,] cube = new int[rows, cols];

            cube = CreateCube(dimensions);

            int numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                var commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                cube = ShufflingCube(cube, commands);
            }

            GetBackToInitialOrder(cube);
        }

        static void GetBackToInitialOrder(int[,] cube)
        {
            int counter = 1;
            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    int currentElement = cube[row, col];
                    
                    if (currentElement == counter)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        for (int rows = 0; rows < cube.GetLength(0); rows++)
                        {
                            for (int cols = 0; cols < cube.GetLength(1); cols++)
                            {
                                if (cube[rows, cols] == counter)
                                {
                                    Console.WriteLine($"Swap ({row}, {col}) with ({rows}, {cols})");
                                    var coordinate = cube[rows, cols];
                                    cube[rows, cols] = cube[row, col];
                                    cube[row, col] = coordinate;
                                }
                            }
                        }
                    }
                    counter++;
                }
            }
        }

        static int[,] ShufflingCube(int[,] cube, string[] commands)
        {
            int rowOrCol = int.Parse(commands[0]);
            string direction = commands[1];
            int numberOfRotation = int.Parse(commands[2]);


            if (numberOfRotation > 1)
            {
                numberOfRotation--;
                ShufflingCube(cube, new string[] { rowOrCol.ToString(), direction, numberOfRotation.ToString() });
            }

            if (direction == "right")
            {
                int lastRowElement = cube[rowOrCol, cube.GetLength(1) - 1];
                for (int j = cube.GetLength(1) - 1; j > 0; j--)
                {
                    cube[rowOrCol, j] = cube[rowOrCol, j - 1];
                }
                cube[rowOrCol, 0] = lastRowElement;

            }
            else if (direction == "left")
            {
                int firstElement = cube[rowOrCol, 0];
                for (int j = 0; j < cube.GetLength(1) - 1; j++)
                {
                    cube[rowOrCol, j] = cube[rowOrCol, j + 1];
                }
                cube[rowOrCol, cube.GetLength(1) - 1] = firstElement;
            }
            else if (direction == "up")
            {
                int firstElement = cube[0, rowOrCol];
                for (int j = 0; j < cube.GetLength(0) - 1; j++)
                {
                    cube[j, rowOrCol] = cube[j + 1, rowOrCol];
                }
                cube[cube.GetLength(0) - 1, rowOrCol] = firstElement;
            }
            else if (direction == "down")
            {
                int lastElement = cube[cube.GetLength(0) - 1, rowOrCol];
                for (int j = cube.GetLength(0) - 1; j > 0; j--)
                {
                    cube[j, rowOrCol] = cube[j - 1, rowOrCol];
                }
                cube[0, rowOrCol] = lastElement;
            }

            return cube;
        }

        static int[,] CreateCube(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] cube = new int[rows, cols];
            int count = 1;

            for (int row = 0; row < cube.GetLength(0); row++)
            {
                for (int col = 0; col < cube.GetLength(1); col++)
                {
                    cube[row, col] = count;
                    count++;
                }
            }

            return cube;
        }
    }
}
