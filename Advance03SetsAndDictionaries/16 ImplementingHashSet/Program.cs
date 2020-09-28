using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _16_ImplementingHashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 10000;
            int contains = 1000;

            var list = new List<string>(count);
            var hashSet = new HashSet<string>(count);
            StringHashSet set = new StringHashSet(count);
            for (int i = 0; i < count; i++)
            {
                list.Add(i.ToString());
                hashSet.Add(i.ToString());
                set.Add(i.ToString());
            }

            //List
            var timer = new Stopwatch();
            timer.Start();
            for (int i = 0; i < contains; i++)
            {
                bool exist = list.Contains(GenerateString());
            }
            timer.Stop();
            Console.WriteLine($"{timer.ElapsedMilliseconds} -> List ");
            timer.Reset();

            //HashSet
            timer.Start();
            for (int i = 0; i < contains; i++)
            {
                bool exist = hashSet.Contains(GenerateString());
            }
            timer.Stop();
            Console.WriteLine($"{timer.ElapsedMilliseconds} -> Hashset ");
            timer.Reset();

            //Ourcode
            timer.Start();
            for (int i = 0; i < contains; i++)
            {
                bool exist = set.Contains(GenerateString());
            }
            timer.Stop();
            Console.WriteLine($"{timer.ElapsedMilliseconds} -> Ourcode ");
            timer.Reset();


            set.Add("hey");
            set.Add("6");
            set.Add("33");
            set.Add("opa");
            set.Add("hey");
            set.Add("hei");

            Console.WriteLine(set.Contains("33"));
            Console.WriteLine(set.Contains("opa"));
            Console.WriteLine(set.Contains("hey"));
            Console.WriteLine(set.Contains("ola"));


        }

        static string GenerateString(int length = 8)
        {

            //StringBuilder sb = new StringBuilder();
            Random rand = new Random();
            //sb.Append(rand.Next(0, 9));


            return rand.Next(0, 100000).ToString();
        }
    }
}
