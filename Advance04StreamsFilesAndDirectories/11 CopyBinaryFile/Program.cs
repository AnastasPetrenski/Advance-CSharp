using System;
using System.IO;
using System.Linq;

namespace _11_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            using var stream = new FileStream("copyMe.png", FileMode.OpenOrCreate);
            using var writer = new FileStream("./copyTo.png", FileMode.OpenOrCreate);
            byte[] buffer = new byte[1024];

            while (true)
            {
                var bytesRead = stream.Read(buffer, 0, buffer.Length);

                if (bytesRead < buffer.Length)
                {
                    buffer = buffer
                        .Take(bytesRead)
                        .ToArray();
                    writer.Write(buffer, 0, buffer.Length);
                    break;
                }

                writer.Write(buffer, 0, buffer.Length);
            }

            
        }
    }
}
