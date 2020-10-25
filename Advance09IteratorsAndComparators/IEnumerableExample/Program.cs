using System;
using System.Collections.Generic;
using System.Data;

namespace IEnumerableExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4 };
            Numbers numbers = new Numbers(new[] { 1, 2, 3, 4, 5, 6 });
            Numbers data = new Numbers(new int[] { 1, 2, 4 });
            Numbers array = new Numbers(arr);

            //foreach (var number in numbers)
            //{

            //}

            var dayOne = "07.10.2020";
            var dayTwo = "08.10.2020";
            DateTime day1 = DateTime.Parse(dayOne, System.Globalization.CultureInfo.CurrentCulture);
            DateTime day2 = DateTime.Parse(dayTwo, System.Globalization.CultureInfo.CurrentCulture);
            if (day1 > day2)
            {
                Console.WriteLine(day1);
            }
            else
            {
                Console.WriteLine(day2);
            }

            int a = 5;
            int b = 10;
            int c = 15;
            int[] arrays = new int[3] { b, a, c };
            Console.WriteLine(string.Join(" ", arrays));
            for (int i = 0; i < arrays.Length - 2; i++)
            {
                arrays[i] = arrays[i].CompareTo(arrays[i + 1]);
            }
            var x = a.CompareTo(b);
            Console.WriteLine(x);
            Console.WriteLine(string.Join(" ", arrays));
        }
    }
}
