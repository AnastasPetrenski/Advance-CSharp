using System;
using System.Collections.Generic;

namespace Tuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split();
            string name = $"{data[0]} {data[1]}";
            string address = data[2];
            Box<string, string> nameAddress = new Box<string, string>(name, address);
            Console.WriteLine(nameAddress.ToString());

            data = Console.ReadLine().Split();
            name = data[0];
            int beer = int.Parse(data[1]);
            Box<string, int> nameLiters = new Box<string, int>(name, beer);
            Console.WriteLine(nameLiters.ToString()); 

            data = Console.ReadLine().Split();
            int itemOne = int.Parse(data[0]);
            double itemTwo = double.Parse(data[1]);
            Box<int, double> intDouble = new Box<int, double>(itemOne, itemTwo);
            Console.WriteLine(intDouble.ToString());
        }
    }
}
