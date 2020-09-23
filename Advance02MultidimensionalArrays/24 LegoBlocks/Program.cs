using System;
using System.Collections.Generic;
using System.Linq;

namespace _24_LegoBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaggedRows = int.Parse(Console.ReadLine());
            int[][] firstArray = new int[jaggedRows][];
            int[][] secondArray = new int[jaggedRows][];

            firstArray = GenerateJaggedArray(jaggedRows);
            secondArray = GenerateJaggedArray(jaggedRows);

            secondArray = ReverseSecondJaggedArray(secondArray);

            MergeCompareJaggedArrays(firstArray, secondArray, jaggedRows);

        }

        static void MergeCompareJaggedArrays(int[][] first, int[][] second, int jaggedRows)
        {
            List<int> mergeArrays = new List<int>();
            int[][] matrix = new int[jaggedRows][];
            for (int i = 0; i < jaggedRows; i++)
            {
                int[] front = first[i];
                int[] back = second[i];
                matrix[i] = front.Concat(back).ToArray();
                mergeArrays.Add(matrix[i].Length);
            }

            if (mergeArrays.Distinct().Count() == 1)
            {
                if (matrix.Length == mergeArrays[0])
                {
                    Console.WriteLine($"The total number of cells is: {mergeArrays.Sum()}");
                    return;
                }

                foreach (var array in matrix)
                {
                    Console.Write("[");
                    Console.Write(string.Join(", ", array));
                    Console.WriteLine("]");
                }
            }
            else
            {
                Console.WriteLine($"The total number of cells is: {mergeArrays.Sum()}");
            }

        }

        static int[][] ReverseSecondJaggedArray(int[][] secondArray)
        {
            for (int row = 0; row < secondArray.GetLength(0); row++)
            {
                for (int i = 0; i < secondArray[row].Length / 2; i++)
                {
                    var lastNumber = secondArray[row][secondArray[row].Length - 1 - i];
                    secondArray[row][secondArray[row].Length - 1 - i] = secondArray[row][i];
                    secondArray[row][i] = lastNumber;
                }
                
            }
            return secondArray;
        }

        static int[][] GenerateJaggedArray(int iterations)
        {
            int[][] jagged = new int[iterations][];
            for (int i = 0; i < iterations; i++)
            {
                int[] arr = ReadAndConvertInput();
                jagged[i] = arr;
            }

            return jagged;
        }

        static int[] ReadAndConvertInput()
        {
            int[] input = Console
             .ReadLine()
             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();

            return input;
        }

    }
}
