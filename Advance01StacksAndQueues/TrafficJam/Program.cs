using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> cars = new Queue<string>();
            int n = int.Parse(Console.ReadLine());
            string command = string.Empty;
            int count = 0;
            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Any())
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                        
                    }
                }
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
