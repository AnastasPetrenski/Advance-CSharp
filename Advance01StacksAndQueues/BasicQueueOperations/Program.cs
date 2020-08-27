using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < info[1]; i++)
            {
                numbers.Dequeue();
            }

            int minNumber = int.MaxValue;
            if (numbers.Count > 0)
            {
                foreach (var item in numbers)
                {
                    if (item == info[2])
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else if (item < minNumber)
                    {
                        minNumber = item;
                    }
                }
                Console.WriteLine(minNumber);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
