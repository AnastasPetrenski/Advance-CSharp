using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> queries = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Console.WriteLine(queries.Max());
            while (queries.Any())
            {
                int query = queries.Peek();
                if (foodQuantity >= query)
                {
                    foodQuantity -= query;
                    queries.Dequeue();
                }
                else
                {
                    Console.WriteLine($"Orders left: {string.Join(" ", queries)}");
                    return;
                }
            }
            Console.WriteLine("Orders complete");
        }
    }
}
