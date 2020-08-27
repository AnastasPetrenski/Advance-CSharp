using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            Stack<int> collectionInts = new Stack<int>(numbers); 

            string command = string.Empty;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                var commands = command.Split().ToList();
                if (commands.Contains("add"))
                {
                    collectionInts.Push(int.Parse(commands[1]));
                    collectionInts.Push(int.Parse(commands[2]));
                }
                else if (commands.Contains("remove"))
                {
                    int count = int.Parse(commands[1]);
                    if (collectionInts.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            collectionInts.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {collectionInts.Sum()}");
        }
    }
}
