using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Action<int, Func<int, int>> b = PrintOperation;
            Func<int, int> calculation = x => x * x;
            int c = Operation(a, c => FunctionSum(a,c));
            b(c, x => FunctionMultiply(x,c));
            b(c, calculation);


            AnotherFunction(SomeFunction);
            var x = SecondFunction(FunctionSum);
            Console.WriteLine(x);
            RunTheMethod(() => Method1("MyString1"));

            Func<int, int, int> func = FunctionSum;
            Console.WriteLine(func);
        }

        private static int Operation(int number, Func<int, int> operation)
        {
            return operation(number);
        }

        static void PrintOperation(int number, Func<int, int> operation)
        {
            int c = Operation(number, operation);
            Console.WriteLine(c);
        }

        static void AnotherFunction(Action<int, string, bool> action)
        {
            action(1, "", true);
        }

        static void SomeFunction(int num, string text, bool isTrue)
        {
            Console.WriteLine("Test");
        }

        public static bool SecondFunction(Func<int, int, int> func)
        {
            int c = 5;
            int d = 5;
            Func<int, int, int> r = (a, b) => 5 + 5;
            int a = 0;
            int b = 0;
            int csd = r(a, b);
            Console.WriteLine(csd);
            var result = (FunctionSubtract(c,d));
            Console.WriteLine(result);
            bool boo = csd == result ? true : false;
            return boo;
        }

        public static int FunctionSum(int z, int x)
        {
            //int result = 5 + 5;
            return z + x;
        }

        public static int FunctionSubtract(int z, int x)
        {
            return z - x;
        }

        public static int FunctionMultiply(int z, int x)
        {
            return z * x;
        }

        public static int Method1(string mystring)
        {
            Console.WriteLine(1);
            return 1;
        }

        public static int Method2(string mystring)
        {
            return 2;
        }

        public static bool RunTheMethod(Action myMethodName)
        {
            myMethodName();   // note: the return value got discarded
            return true;
        }


    }
}