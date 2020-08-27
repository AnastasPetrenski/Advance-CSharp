using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> players = new Queue<string>(Console.ReadLine().Split());
            int n = int.Parse(Console.ReadLine());
            while (players.Count > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i < n)
                    {
                        var name = players.Dequeue();
                        players.Enqueue(name);
                    }
                    else if (i == n)
                    {
                        Console.WriteLine($"Removed {players.Dequeue()}"); 
                    }
                }
            }

            Console.WriteLine($"Last is {players.Dequeue()}");
        }
    }
}
