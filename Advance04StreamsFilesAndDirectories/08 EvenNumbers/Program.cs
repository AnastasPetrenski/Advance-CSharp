using System;
using System.IO;
using System.Linq;
using System.Text;

namespace _08_EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("text.txt");
            int counter = 0;
            char[] substitutes = new char[] { '-', ',', '.', '!', '?' };

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    line = ReplaceSubstitesChars(line, substitutes);

                    line = ReverseWordsLine(line);

                    Console.WriteLine(line);
                }

                counter++;
            }
        }

        public static string ReplaceSubstitesChars(string line, char[] substitutes)
        {
            var output = new StringBuilder();
            for (int i = 0; i < line.Length; i++)
            {
                char curChar = line[i];
                if (substitutes.Contains(curChar))
                {
                    curChar = '@';
                }
                output.Append(curChar);
            }

            return output.ToString().TrimEnd();
        }

        public static string ReverseWordsLine(string line)
        {
            var output = new StringBuilder();
            var words = line.Split(" ").ToArray();
            for (int i = 0; i < words.Length; i++)
            {
                output.Append(words[words.Length - 1 - i]);
                output.Append(" ");
            }

            return output.ToString().TrimEnd();
        }
    }
}
