using Microsoft.VisualBasic;
using System;
using System.IO;

namespace _03_LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream result = new FileStream("Result.txt", FileMode.OpenOrCreate);

            using var reader = new StreamReader("Text.txt");

            using var writer = new StreamWriter(result);

            int counter = 1;

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }
                writer.WriteLine($"{counter}. {line}");

                counter++;
            }
        }
    }
}
