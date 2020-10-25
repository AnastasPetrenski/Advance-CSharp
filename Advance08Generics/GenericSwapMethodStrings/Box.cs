using System;
using System.Collections.Generic;
using System.Text;

namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        private List<T> elements;

        public Box()
        {
            this.elements = new List<T>();
        }

        public void AddElement(T element)
        {
            this.elements.Add(element);
        }

        public void SwapElements(int elementOne, int elementTwo)
        {
            var temp = this.elements[elementOne];
            this.elements[elementOne] = this.elements[elementTwo];
            this.elements[elementTwo] = temp;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in this.elements)
            {
                sb.AppendLine($"{item.GetType()}: {item}");
            }

            return sb.ToString().Trim();
        }
    }
}
