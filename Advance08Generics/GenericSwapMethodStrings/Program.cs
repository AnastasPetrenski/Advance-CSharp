using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<string> list = new Box<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                list.AddElement(input);
            }

            var indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int firstElement = indexes[0];
            int secondElement = indexes[1];

            list.SwapElements(firstElement, secondElement);
            
            Console.WriteLine(String.Join(Environment.NewLine, list));
        }
    }
}
