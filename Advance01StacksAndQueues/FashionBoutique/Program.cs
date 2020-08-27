using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int capacity = int.Parse(Console.ReadLine());
            int racks = 0;
            while (clothes.Any())
            {
                int result = 0;
                while (clothes.Any())
                {
                    int clotheValue = clothes.Peek();
                    if (result + clotheValue <= capacity)
                    {
                        result += clothes.Pop();
                    }
                    else
                    {
                        break;
                    }
                }

                racks++;
            }

            Console.WriteLine(racks);
        }
    }
}
