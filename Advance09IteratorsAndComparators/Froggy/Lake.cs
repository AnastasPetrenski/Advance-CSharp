using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Froggy
{
    public class Lake<T> : IEnumerable<T>
    {
        public Lake(List<T> numbers)
        {
            this.Numbers = numbers;
        }

        public List<T> Numbers { get; set; }

        public IEnumerator<T> GetEnumerator()
        {
            List<T> arr1 = new List<T>();
            List<T> arr2 = new List<T>();
            for (int i = 0; i < Numbers.Count; i++)
            {
                if (i % 2 == 0)
                {
                    arr1.Add(Numbers[i]);
                }
                else
                {
                    arr2.Add(Numbers[i]);
                }
            }

            arr2.Reverse();
            arr1 = arr1.Concat(arr2).ToList();

            for (int i = 0; i < arr1.Count; i++)
            {
                yield return arr1[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
