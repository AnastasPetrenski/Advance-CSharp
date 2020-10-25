using System;

namespace InterfaceAnimal
{
    class Program
    {
        static void Main(string[] args)
        {

            Dog<string> dog = new Dog<string>();
            Console.WriteLine(dog.Name);
        }
    }
}
