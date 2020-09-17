using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AnotherFunction(SomeFunction);
            var x = SecondFunction(Function);
            Console.WriteLine(x);
            RunTheMethod(() => Method1("MyString1"));

            Func<int, int, int> func = Function;
            Console.WriteLine(func);
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
            Func<int, int, int> r = (a,b) => 5+5;
            
            bool boo = r.Equals(func) ? true : false;
            return boo;
        }

        public static int Function(int z, int x)
        {
            int result = 5 + 5;
            return result;
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