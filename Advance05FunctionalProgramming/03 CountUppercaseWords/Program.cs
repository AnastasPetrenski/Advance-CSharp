using System;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace _03_CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func<string, bool> checkIsUpper = n => n[0] == n.ToUpper()[0];
            Func<string, bool> checkIsUpper = CheckIsUppercase;

            Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(checkIsUpper)
                .ToList()
                .ForEach(Console.WriteLine);

                
        }

        public static bool CheckIsUppercase(string word)
        {
            char firstLetter = word[0];
            if (char.IsUpper(firstLetter))
            {
                return true;
            }

            return false;
        }
    }
}
