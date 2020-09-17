using System;
using System.Collections.Generic;
using System.Linq;

namespace Advance05FunctionalProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array of Point structures.
            Point[] points = { new Point(100, 200),
                         new Point(150, 250), new Point(250, 375),
                         new Point(275, 395), new Point(295, 450) };

            // Define the Predicate<T> delegate.
            Predicate<Point> predicate = FindPoints;

            // Find the first Point structure for which X times Y
            // is greater than 100000.
            Point first = Array.Find(points, predicate);

            // Display the first structure found.
            Console.WriteLine("Found: X = {0}, Y = {1}", first.X, first.Y);

            Console.WriteLine("##############################");
            //#############################################//
            //list example

            List<int> ints = new List<int>() { 1, 2, 3, 4, 5 };
            var odd = ints.FindAll(x => x % 2 == 1).ToList();
            Console.WriteLine("List example find all odd numbers:");
            Console.WriteLine(string.Join(" ", odd));

            Console.WriteLine("##############################");
            //#############################################//

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            Predicate<int> predicated = FindEvenNumber;

            int even = Array.Find(numbers, predicated);
            var evens = Array.FindAll(numbers, x => x % 2 == 0).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
            Console.WriteLine($"Found first even number from array: {even}");
            Console.WriteLine(string.Join(" ", evens));
        }

        private static bool FindEvenNumber(int number)
        {
            return number % 2 == 0;
        }

        private static bool FindPoints(Point obj)
        {
            return obj.X * obj.Y > 100000;
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
