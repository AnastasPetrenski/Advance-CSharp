using System;

namespace _16_ImplementingHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHashSet set = new StringHashSet();

            set.Add("hey");
            set.Add("6");
            set.Add("33");
            set.Add("opa");
            set.Add("hey");
            set.Add("hei");

            Console.WriteLine(set.Contains("33"));
            Console.WriteLine(set.Contains("opa"));
            Console.WriteLine(set.Contains("hey"));
            Console.WriteLine(set.Contains("76"));

           
        }
    }
}
