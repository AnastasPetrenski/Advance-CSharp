using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var info = Console.ReadLine().Split().Select(int.Parse).ToList();
            int poppedElements = info[1];
            int lookUpNumber = info[2];
            Stack<int> numbers = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            for (int i = 0; i < poppedElements; i++)
            {
                if (numbers.Any())
                {
                    numbers.Pop();
                }
                //int result = 0;
                //numbers.TryPop(out result);
            }

            int minNumber = int.MaxValue;
            if (numbers.Any())
            {
                foreach (var number in numbers)
                {
                    if (number == lookUpNumber)
                    {
                        Console.WriteLine("true");
                        return;
                    }
                    else if (number < minNumber)
                    {
                        minNumber = number;
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
