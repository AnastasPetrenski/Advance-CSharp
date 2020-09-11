using System;
using System.IO.Compression;

namespace _13_ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"..\..\..\start";
            string zipPath = ".result.zip";
            string extractPath = @".";
            ZipFile.CreateFromDirectory(startPath, zipPath);
            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
