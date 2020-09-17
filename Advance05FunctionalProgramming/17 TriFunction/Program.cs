using System;
using System.Collections.Generic;
using System.Linq;

namespace _17_TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split();

            foreach (var item in names)
            {
                GetTheBiggestName(item, target);

                
            }
        }

        public static bool GetTheBiggestName(string item, int target)
        {
            var length = 0;
            for (int i = 0; i < item.Length; i++)
            {
                length += item[i];
            }

            CompareResultsWithTarget(length, target, item);

            return false;
        }

        public static void CompareResultsWithTarget(int length, int target, string item)
        {
            if (length >= target)
            {
                Console.WriteLine(item);
                return;
            }
        }
    }
}