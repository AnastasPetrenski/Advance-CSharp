using System;
using System.IO;

namespace Advance04StreamsFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream file = new FileStream("TextTest.txt");
            StreamWriter writer = new StreamWriter("result.txt");

            using (writer)
            {
                writer.Write("Text");
            }

            using StreamReader reader = new StreamReader("result.txt");

            string result = reader.ReadLine();

            Console.WriteLine(result);

            using var read = new StreamReader("TextTest.txt");
            string test = read.ReadLine();

            Console.WriteLine(test);
        }
    }
}
