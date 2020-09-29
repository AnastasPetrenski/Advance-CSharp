using System;

namespace Advance06DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5; //value type / premitive type - they are copied in the Stack
            Print(a); // If we print the return value of the method Print than a = 1000

            Console.WriteLine(a); // Print 5

             /* 
             * Referent types are class, objects and other bif structures. Their data is not copied.
             * They are stored in the Heep. The name are stored in the Stack and it is a address which points to the Heep.
             * The address is in 16/HEXadecimal/ number system.
             */
            int[] arr = new int[] { 1, 2, 3 };  
            int[] num = arr;
            num[0] = 100;

            Console.WriteLine(arr[0]);

            Cat cat = new Cat();
            cat.Name = "Ivan"; //missing Set property
            cat.Color = "red";
            var name = cat.Name;
            Console.WriteLine(cat.Details);
        }

        static int Print(int a) 
        {
            a = 1000;
            return a;
        }
    }

    class Cat
    {
        private string name;
        private string color;

        public int Age { get; set; }

        public string Color 
        {
            get { return this.color; }
            set 
            {
                if (value != "red")
                {
                    throw new ArgumentException();
                }

                this.color = value;
            } 
        }

        public string Name 
        {
            get { return this.name; }
            set 
            {
                if (value != "Ivan")
                {
                    throw new InvalidCastException("Cannot be empty string. Try again!");
                }

                this.name = value;
            }
        }

        public string Details 
        { 
            get 
            { 
                return $"{this.Age} {this.Color} {this.Name}"; 
            } 
        }
    }
}
