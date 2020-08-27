using System;

namespace _07_PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            long[][] triangle = new long[dimensions][];
            if (dimensions < 1)
            {
                Console.WriteLine(0);
                return;
            }

            if (dimensions >= 1)
            {
                triangle[0] = new long[] { 1 };
            }

            if (dimensions >= 2)
            {
                triangle[1] = new long[] { 1, 1 };
            }

            for (int row = 2; row < dimensions; row++)
            {
                triangle[row] = new long[row + 1];
                triangle[row][0] = 1;

                for (int col = 1; col < row; col++)
                {
                    triangle[row][col] =
                        triangle[row - 1][col] +
                        triangle[row - 1][col - 1];
                }

                triangle[row][row] = 1;
                
            }

            foreach (var item in triangle)
            {
                Console.WriteLine(string.Join(" ", item));
            }

            // <<< How to made triangle => piramid >>>
            //int lastRowLength = string.Join(" ", triangle[dimention - 1]).Length;
            //for (int row = 0; row < triangle.Length; row++)
            //{
            //    string currentRowText = string.Join(" ", triangle[row]);
            //    int diff = lastRowLength - currentRowText.Length;
            //    int halfDiff = diff / 2;

            //    string whiteSpace = new string(' ', halfDiff);

            //    Console.WriteLine($"{whiteSpace}{currentRowText}");
            //}
        }
    }
}
