using System;
using System.Threading;

namespace Advance08Generics
{
    public class Animal
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bauuu");
        }
    }

    public class Puppy : Dog
    {
        public string FatherName { get; set; }
    }

    class StartUp
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.Name = "Nasko";

            //Puppy puppy = new Puppy();
            //puppy.Bark();
            //puppy.FatherName = dog.Name;
            //Console.WriteLine(puppy.FatherName);
            Console.WriteLine("First question!");
            Thread.Sleep(3000);
            Console.WriteLine("When Vasil Levski was born?");
            Thread.Sleep(3000);
            Console.WriteLine("1. 1976  2. 1936");
            Console.WriteLine("3. 1973  4. 1937");
            string answer = Console.ReadLine();
            if (answer == "1937")
            {
                Console.WriteLine("Right answer!");
                Console.WriteLine("Second Question!");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("When Vasil Levski Die?");
                Console.WriteLine("1. 1976  2. 1936");
                Console.WriteLine("3. 1973  4. 1937");
            }
            else if (answer == "50/50")
            {
                Console.Clear();
                Console.WriteLine("When Vasil Levski was born?");
                Thread.Sleep(1000);
                Console.WriteLine("1. 1976  2.     ");
                Console.WriteLine("3.       4. 1937");

            }
            else
            {
                Console.WriteLine("Game Over!");
            }

        }
    }
}
