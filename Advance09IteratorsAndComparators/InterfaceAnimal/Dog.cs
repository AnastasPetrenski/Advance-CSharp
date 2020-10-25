using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAnimal
{
    public class Dog<T> : IAnimal
    {
        private string name = "Pesho";

        public Dog()
        {
            this.Name = name;
        }

        public string Name { get; }

        public void Move(int x, int y)
        {
            
        }
    }
}
