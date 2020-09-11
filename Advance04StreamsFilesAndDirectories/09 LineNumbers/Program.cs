using System;
using System.IO;
using System.Linq;

namespace _09_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = File.ReadLines("text.txt");
            char[] substitutes = new char[] { '-', ',', '.', '!', '?', '\'' };
            int lineCounter = 1;

            foreach (var line in text)
            {
                int lettersCounter = 0;
                int symbolsCounter = 0;
                for (int i = 0; i < line.Length; i++)
                {
                    char element = line[i];
                    if (char.IsLetter(element))
                    {
                        lettersCounter++;
                    }
                    else if (substitutes.Contains(element))
                    {
                        symbolsCounter++;
                    }
                }
                Console.WriteLine($"Line {lineCounter}: {line} ({lettersCounter})({symbolsCounter})");
                lineCounter++;
            }
        }
    }
}
