using System;
using System.IO;

namespace _02_OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using StreamReader reader = new StreamReader("OddLines.txt");
            using StreamWriter writer = new StreamWriter("Result.txt", append:false); // append:false - clear all text, is true: adding text and keeping
            int counter = 0;

            while (true)
            {
                var line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }
                
                if (counter % 2 == 1)
                {
                    writer.WriteLine(line);
                }

                counter++;
            }
            writer.Flush();
            writer.Close();

            using StreamReader readResult = new StreamReader("Result.txt");
            var output = readResult.ReadToEnd();
            Console.WriteLine(output);
        }
    }
}
