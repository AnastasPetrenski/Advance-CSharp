using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries));
            while (songs.Any())
            {
                var input = Console.ReadLine().Split().ToList();
                string command = input[0];
                if (command == "Play")
                {
                    songs.Dequeue();
                }
                else if (command == "Add")
                {
                    var song = new StringBuilder();
                    for (int i = 1; i < input.Count; i++)
                    {
                        song.Append(input[i]);
                        if (i < input.Count-1)
                        {
                            song.Append(" ");
                        }
                    }
                    if (!songs.Contains(song.ToString()))
                    {
                        songs.Enqueue(song.ToString());
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
