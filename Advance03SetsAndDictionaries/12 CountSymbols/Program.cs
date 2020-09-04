using System;
using System.Collections.Generic;

namespace _12_CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine()
                .ToCharArray();

            SortedDictionary<char, int> counterElements = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (!counterElements.ContainsKey(symbol))
                {
                    counterElements.Add(symbol, 0);
                }

                counterElements[symbol]++;
            }

            foreach (var symbol in counterElements)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
