using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCountMethodDoubles
{
    public class Box<T> where T : IComparable<T>
    {
        public List<T> Elements { get; set; }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }

        public void CountGreaterElements(List<T> elements, T element)
        {
            int count = 0;
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }

}
