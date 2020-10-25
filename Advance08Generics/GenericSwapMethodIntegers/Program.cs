using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<int> elements = new Box<int>();
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                elements.AddElement(input);
            }

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            elements.SwapElements(indexes[0], indexes[1]);

            elements.ToString();
        }
    }
}
