using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;

namespace _05_MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using var readFirstFile = new StreamReader("First.txt");
            using var readSecondFile = new StreamReader("Second.txt");

            var firstFile = readFirstFile
                .ReadToEnd()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var secondFile = readSecondFile
                .ReadToEnd()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();



            var mergedFile = new FileStream("Result.txt", FileMode.OpenOrCreate);

            int length = Math.Max(firstFile.Length, secondFile.Length);

            for (int i = 0; i < length; i++)
            {
                var x = Encoding.UTF8.GetBytes(firstFile[i]);
                var y = Encoding.UTF8.GetBytes(secondFile[i]);
                if (i < firstFile.Length)
                {
                    mergedFile.Write(x, 0, x.Length);
                }

                if (i < secondFile.Length)
                {
                    mergedFile.Write(y, 0, y.Length);
                }
            }

            byte[] buffer = new byte[50];

            StringBuilder result = new StringBuilder();

            while (true)
            {
                var totalBytes = mergedFile.Read(buffer, 0, buffer.Length);
                if (totalBytes < buffer.Length)
                {
                    var diff = buffer.Take(totalBytes).ToArray();
                    result.Append(Encoding.UTF8.GetString(diff));
                    break;
                }

                result.Append(Encoding.UTF8.GetString(buffer));

            }
            mergedFile.Close();
            //Console.WriteLine(result.ToString());
            using StreamReader reader = new StreamReader("Result.txt");
            var printResult = reader.ReadToEnd();
            Console.WriteLine(printResult);
        }
    }
}
