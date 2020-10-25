using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GenericCountMethodString
{
    public class Box<T> where T : IComparable, ICloneable, IComparable<T>
    {
        public List<T> Elements { get; set; }

        public Box(List<T> elements)
        {
            this.Elements = elements;
        }

        public int CountGreaterElements(List<T> list, T element)
        {
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].CompareTo(element) > 0)
                {
                    count++;
                }
            }

            return count;
        }

        //public static void Comparator<T>(List<T> elements, T element)
        //{
        //    int count = 0;
        //    int sumComparedElement = 0;
        //    string compared = element.ToString();
        //    for (int k = 0; k < compared.Length; k++)
        //    {
        //        sumComparedElement += compared[k];
        //    }

        //    for (int i = 0; i < elements.Count; i++)
        //    {
        //        string item = elements[i].ToString();
        //        int sumCurrentElement = 0;
        //        for (int j = 0; j < item.Length; j++)
        //        {
        //            sumCurrentElement += item[j];
        //        }

        //        if (sumCurrentElement > sumComparedElement)
        //        {
        //            count++;
        //        }
        //    }

        //    Console.WriteLine(count);
        //}

    }
}
