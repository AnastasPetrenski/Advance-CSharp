using System;
using System.IO;

namespace _01_RECURSION_GetPathDirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // var files = Directory.GetFiles("."); - "." mean take all files in current directory
            //Console.WriteLine(string.Join(Environment.NewLine, files));
            var path = @"C:\Users\anastas\source\Examples From C# book Nakov";

            PrintDirectoryInfo(path, string.Empty);
        }

        static void PrintDirectoryInfo(string path, string prefix)
        {
            var directories = Directory.GetDirectories(path);

            var directoriesInfo = new DirectoryInfo(path);

            Console.WriteLine($"{prefix}Dir: {directoriesInfo.Name}");

            foreach (var directory in directories)
            {
                PrintDirectoryInfo(directory, prefix += "--");
            }

            var files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                var filesInfo = new FileInfo(file);

                Console.WriteLine($"{prefix}- File: {filesInfo.Name}");
            }
        }
    }
}
