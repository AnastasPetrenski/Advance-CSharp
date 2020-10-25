using System;
using System.Collections.Generic;

namespace GenericCountMethodString
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.Add(input);
            }

            var element = Console.ReadLine();
            var box = new Box<string>(list);
            Console.WriteLine(box.CountGreaterElements(list, element));
        }
    }
}
