using System;

namespace _17_BitwiseAndShiftOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Unary ~ (bitwise complement) operator
             * Binary << (left shift) and >> (right shift) shift operators
             * Binary & (logical AND), | (logical OR), and ^ (logical exclusive OR) operators
             */

            int a = 14;
            Console.WriteLine($"before shifting = {a}");
            var binary = Convert.ToString(a, 2);
            Console.WriteLine(binary);
            var b = a >> 1;
            binary = Convert.ToString(b, 2);
            Console.WriteLine($"after right shifting = {b}");
            Console.WriteLine(binary);
            var c = a << 1;
            binary = Convert.ToString(c, 2);
            Console.WriteLine($"after left shifting = {c}");
            Console.WriteLine(binary);
            var binaryReverse = ~c;
            binary = Convert.ToString(binaryReverse, 2);
            Console.WriteLine($"after left shifting and binary reverse = {binaryReverse}");
            Console.WriteLine(binary);
        }
    }
}
