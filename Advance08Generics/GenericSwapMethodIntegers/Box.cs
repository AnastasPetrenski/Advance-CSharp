using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodIntegers
{
    public class Box<T>
    {
        public Box()
        {
            this.Elements = new List<T>();
        }

        public List<T> Elements { get; set; }

        public void AddElement(T element)
        {
            this.Elements.Add(element);
        }

        public void SwapElements(int indexOne, int indexTwo)
        {
            var temp = this.Elements[indexOne];
            this.Elements[indexOne] = this.Elements[indexTwo];
            this.Elements[indexTwo] = temp;
        }

        public override string ToString()
        {
            foreach (var item in this.Elements)
            {
                Console.WriteLine($"{item.GetType()}: {item}");
            }

            return "";
        }
    }
}
