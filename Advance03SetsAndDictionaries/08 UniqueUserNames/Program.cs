using System;
using System.Collections.Generic;

namespace _08_UniqueUserNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                userNames.Add(name);
            }

            Console.WriteLine(string.Join(Environment.NewLine, userNames));
        }
    }
}
