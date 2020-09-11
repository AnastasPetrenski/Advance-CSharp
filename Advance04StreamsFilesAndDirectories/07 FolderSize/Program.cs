using System;
using System.IO;

namespace _07_FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(".");

            var totalSize = 0m;

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                totalSize += fileInfo.Length;
            }

            Console.WriteLine($"{totalSize / 1024 / 1024:F4} MB");
        }
    }
}
