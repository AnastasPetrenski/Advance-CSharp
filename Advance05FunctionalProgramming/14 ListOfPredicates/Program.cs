using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _14_ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayBoundary = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split().Select(int.Parse).OrderBy(x => x).Distinct().ToList();
            var arr = Enumerable.Range(1, Math.Abs(arrayBoundary)).ToList();

            List<Predicate<int>> predicates = new List<Predicate<int>>();
            dividers.ForEach(d => predicates.Add(x => x % d == 0));
            var result = new List<int>();
            for (int i = 1; i <= arr.Count; i++)
            {
                bool isDivisible = true;
                foreach (var item in predicates)
                {
                    if (!item(i))
                    {
                        isDivisible = false;
                        break;
                    }
                }

                if (isDivisible)
                {
                    result.Add(i);
                }
            }


            //for (int i = 0; i < dividers.Count; i++)
            //{
            //    arr = arr.Where(x => x % dividers[i] == 0).ToList();
            //}
            //Console.WriteLine(string.Join(" ", arr));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
