using System;
using System.Collections;
using System.Collections.Generic;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            Queue<string> customers = new Queue<string>();
            while ((name = Console.ReadLine()) != "End")
            {
                if (name == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, customers));
                    customers.Clear();
                }
                else
                {
                    customers.Enqueue(name);
                }
            }

            Console.WriteLine($"{customers.Count} people remaining.");
        }
    }
}
