using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> list = new Stack<string>(Console.ReadLine().Split().Reverse());
            while (list.Count > 1)
            {
                int firstNumber = int.Parse(list.Pop());
                string operation = list.Pop();
                var secondNumber = int.Parse(list.Pop());
                    
                var result = operation switch
                {
                    "+" => (firstNumber + secondNumber),
                    "-" => (firstNumber - secondNumber),
                    _ => 0
                };

                list.Push(result.ToString());
            }

            Console.WriteLine(list.Pop());
        }
    }
}
