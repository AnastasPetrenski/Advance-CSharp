using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<int> index = new Stack<int>();

            for (int i = 0; i < text.Length; i++)
            {
                var symbol = text[i];
                if (symbol == '(')
                {
                    index.Push(i);
                }
                else if (symbol == ')')
                {
                    int indexOfOpeningBracket = index.Pop();
                    string substring = text.Substring(indexOfOpeningBracket, i - indexOfOpeningBracket + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
