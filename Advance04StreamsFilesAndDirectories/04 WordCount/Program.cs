using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace _04_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            using var readLookupWords = new StreamReader("Words.txt");
            using var inputReader = new StreamReader("text.txt");
            char[] separators = new char[] { '!', '.', ' ', ',', ';', '?', '-', ':' };
            List<string> words = readLookupWords
                .ReadToEnd()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            Dictionary<string, int> matchedWords = new Dictionary<string, int>();

            while (true)
            {
                string lineFromInput = inputReader.ReadLine();

                if (lineFromInput == null)
                {
                    break;
                }

                List<string> separatedInput = lineFromInput
                    .ToLower()
                    .Split(separators, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int i = 0; i < separatedInput.Count; i++)
                {
                    string singleWord = separatedInput[i];
                    if (words.Contains(singleWord))
                    {
                        if (!matchedWords.ContainsKey(singleWord))
                        {
                            matchedWords.Add(singleWord, 0);
                        }

                        matchedWords[singleWord]++;
                    }
                }
            }

            foreach (var (wordKey, wordValue) in matchedWords.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{wordKey} - {wordValue}");
            }
        }
    }
}
