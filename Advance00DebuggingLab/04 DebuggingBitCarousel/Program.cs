using System;

namespace _04_DebuggingBitCarousel
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            byte rotations = byte.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string direction = Console.ReadLine();

                if (direction == "right")
                {
                    int rightMostBit = number & 1;
                    number >>= 1;
                    number |= (byte)(rightMostBit << 6);
                }
                else if (direction == "left")
                {
                    int leftMostBit = number & 1;
                    number <<= 1;
                    number |= (byte)(leftMostBit >> 6);
                }
            }

            Console.WriteLine(number);
        }
    }
}
