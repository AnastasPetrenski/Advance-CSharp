using System;

namespace _03_DebuggingSubstring
{
    public class Substring_broken
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char Search = 'р';
            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                if (letter == 'p')
                {
                    hasMatch = true;

                    int endIndex = jump+1;

                    if (endIndex + i > text.Length)
                    {
                        endIndex = text.Length - i;
                    }

                    string matchedString = text.Substring(i, endIndex);
                    Console.WriteLine(matchedString);
                    i += jump;
                }
                
                if (i > text.Length)
                {
                    break;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
