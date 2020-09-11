using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _12_DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ".";
            var directories = Directory.GetDirectories(path);
            var files = Directory.GetFiles(path);
            using var writer = new FileStream("report.txt", FileMode.OpenOrCreate);
            Dictionary<string, Dictionary<string, long>> orderedFiles = new Dictionary<string, Dictionary<string, long>>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);
                var fileSize = fileInfo.Length;
                var fileName = fileInfo.Name;
                //fileFullInfo.Append($"{fileName} - {fileSize:F3}kb");
                var extension = fileName.Substring(fileName.LastIndexOf('.'));
                if (!orderedFiles.ContainsKey(extension))
                {
                    orderedFiles.Add(extension, new Dictionary<string, long>());
                    orderedFiles[extension].Add(fileName, fileSize);
                }
                else
                {
                    orderedFiles[extension].Add(fileName, fileSize);
                }
            }

            foreach (var extension in orderedFiles.OrderByDescending(x => x.Value.Keys.Count).ThenBy(y => y.Key))
            {
                
                Console.WriteLine(extension.Key);
                var buffer = new byte[extension.Key.Length];
                buffer = Encoding.UTF8.GetBytes(extension.Key);
                byte[] newline = Encoding.UTF8.GetBytes(Environment.NewLine);
                writer.Write(buffer, 0, extension.Key.Length);
                writer.Write(newline, 0, newline.Length);
                foreach (var file in extension.Value.OrderBy(x => x.Value))
                {
                    var kb = file.Value*1.00 / 1024;
                    Console.WriteLine($"--{file.Key} - {kb:f3}kb");
                    string line = $"--{file.Key} - {kb:f3}kb";
                    var buffer1 = new byte[line.Length];
                    buffer1 = Encoding.UTF8.GetBytes(line);
                    writer.Write(buffer1, 0, line.Length);
                    writer.Write(newline, 0, newline.Length);
                }
            }
            writer.Close();
            StreamReader stream = new StreamReader("report.txt");
            var text = stream.ReadToEnd();
            Console.WriteLine(text);
            //Console.WriteLine(string.Join("--", string.Join(Environment.NewLine, files)));
        }
    }
}
