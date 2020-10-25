using System;
using System.Collections.Generic;

namespace Threeuple
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 2;
            double x = a / (double)b;
            bool isBigger = 5 > 10;
            Console.WriteLine(isBigger);

            string[] data = Console.ReadLine().Split();
            string name = $"{data[0]} {data[1]}";
            string address = data[2];
            string town = data[3];
            Threeuple<string, string, string> nameAddress = new Threeuple<string, string, string>(name, address, town);
            Console.WriteLine(nameAddress.ToString());

            data = Console.ReadLine().Split();
            name = data[0];
            int beer = int.Parse(data[1]);
            bool isDrunk = data[2] == "drunk" ? true : false;
            Threeuple<string, int, bool> nameLiters = new Threeuple<string, int, bool>(name, beer, isDrunk);
            Console.WriteLine(nameLiters.ToString());

            data = Console.ReadLine().Split();
            string itemOne = data[0];
            double itemTwo = double.Parse(data[1]);
            string itemThree = data[2];
            Threeuple<string, double, string> intDouble = new Threeuple<string, double, string>(itemOne, itemTwo, itemThree);
            Console.WriteLine(intDouble.ToString());

        }
    }
}
