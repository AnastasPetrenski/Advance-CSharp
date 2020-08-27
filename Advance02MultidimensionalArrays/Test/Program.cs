using System;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            Console.WriteLine(string.Join(" ", numbers));

            System.Linq.Expressions.Expression<Func<int, int>> z = x => x * x;
            Console.WriteLine(z);

            var squaredNumbers = numbers.Select(x => x * x);
            Console.WriteLine(string.Join(" ", squaredNumbers));

            int[] numbers1 = { 5, 6, 1, 5, 9, 3, 6, 4, 2, 1 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Func<int, int, string> testForEqualityReturnString = (x, y) => x == y ? "Yes" : "No";
                Func<int, int, bool> testForEqualityReturnBoolean = (x, y) => x == y;
                Console.Write(testForEqualityReturnString(numbers[i], numbers1[i]) + " is: ");
                Console.WriteLine(testForEqualityReturnBoolean(numbers[i], numbers1[i]));
            }

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            var x = a > 2 ? b : (c < 0 ? d : e);
            Console.WriteLine($"Ternary expression return: {x}");

            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            greet("Nasko");

            //The following example uses the Count standard query operator:
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);
            var sumEvenNumbers = numbers.Where(n => n % 2 == 1).Sum();
            Console.WriteLine($"There are {oddNumbers} odd numbers in {string.Join(" ", numbers)}");
            Console.WriteLine($"The sum of the odd numbers are {sumEvenNumbers}");

            //Output: 5 4 1 3
            var firstNumbersLessThanSix = numbers.TakeWhile(n => n < 6);
            Console.WriteLine(string.Join(" ", firstNumbersLessThanSix));

            //Output: 5 4
            var firstSmallNumbers = numbers.TakeWhile((n, index) => n >= index);
            Console.WriteLine(string.Join(" ", firstSmallNumbers));
        }
    }
}
