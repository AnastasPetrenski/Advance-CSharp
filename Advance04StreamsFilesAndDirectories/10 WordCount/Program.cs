using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _10_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = File.ReadLines("words.txt");
            var words = input.ToList();
            var text = File.ReadLines("text.txt");
            Dictionary<string, int> matched = new Dictionary<string, int>();
            foreach (var line in text)
            {
                string[] separateWords = line
                    .Split(new char[] { ' ', ',', '-', '!', '?', '.'}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.ToLower())
                    .ToArray();

                for (int i = 0; i < separateWords.Length; i++)
                {
                    string word = separateWords[i];
                    if (words.Contains(word) && !matched.ContainsKey(word))
                    {
                        matched.Add(word, 1);
                    }
                    else if (words.Contains(word) && matched.ContainsKey(word))
                    {
                        matched[word]++;
                    }
                }
            }

            foreach (var item in matched.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            //Console.WriteLine(string.Join(Environment.NewLine, text));

        }
    }
}
