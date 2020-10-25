using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private int index;

        public ListyIterator(T[] array)
        {
            this.index = 0;
            this.Array = new List<T>(array);
        }

        public List<T> Array { get; set; }

        public bool Move()
        {
            if (HasNext())
            {
                index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            return index + 1 < Array.Count;
        }

        public void Print()
        {
            if (Array.Count > 0)
            {
                Console.WriteLine(Array[index]);
            }
            else
            {
                throw new Exception("Invalid Operation!");
            }
        }

        public void PrintAll()
        {
            if (Array.Count > 0)
            {
                Console.WriteLine(string.Join(" ", Array));
            }
            else
            {
                throw new Exception("Invalid Operation!");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Array.Count; i++)
            {
                yield return Array[i];
            }
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
