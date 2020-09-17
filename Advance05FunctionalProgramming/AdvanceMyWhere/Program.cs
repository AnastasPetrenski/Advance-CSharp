using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdvanceMyWhere
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] { 1.0, 2.0, 3.0 };
            var result = MyWhere(input, x => x % 2 == 0);
            Console.WriteLine(string.Join(" ", result));

            var x = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
        }

        static List<T> MyWhere<T>(IEnumerable<T> input, Func<T, bool> filter)
        {
            var newList = new List<T>();
            foreach (var number in input)
            {
                if (filter(number))
                {
                    newList.Add(number);
                }
            }

            return newList;
        }

        static List<T2> MySelect<T, T2>(IEnumerable<T> input, Func<T, T2> projection)
        {
            var newList = new List<T2>();
            foreach (var number in input)
            {
                newList.Add(projection(number));
            }

            return newList;
        }
    }
}
