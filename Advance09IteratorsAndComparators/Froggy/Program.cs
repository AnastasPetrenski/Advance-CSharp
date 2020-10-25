using System;
using System.Linq;

namespace Froggy
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Lake<int> numbers = new Lake<int>(input);
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
