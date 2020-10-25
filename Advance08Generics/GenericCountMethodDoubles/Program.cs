using System;
using System.Collections.Generic;

namespace GenericCountMethodDoubles
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<double> list = new List<double>();
            for (int i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                list.Add(input);
            }

            double mark = double.Parse(Console.ReadLine());
            Box<double> doubles = new Box<double>(list);
            doubles.CountGreaterElements(list, mark);

        }
    }
}
