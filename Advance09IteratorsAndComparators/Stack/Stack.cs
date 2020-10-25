using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    public class Stack<T> : IEnumerable<T>
    {
        private int index;
        private int capacity = 4;

        public Stack()
        {
            this.index = -1;
            this.Array = new T[capacity];
        }

        public T[] Array { get; set; }

        public void Push(T element)
        {
            if (index >= Array.Length - 1)
            {
                capacity *= 2;
                T[] newArray = new T[capacity];
                for (int i = 0; i <= index; i++)
                {
                    newArray[i] = Array[i];
                }

                Array = newArray;
            }

            this.index++;
            Array[index] = element;
        }

        public T Pop()
        {
            if(index >= 0)
            {
                T element = Array[index];
                Array[index] = default;
                index--;
                return element;
            }
            else
            {
                throw new Exception("No elements");
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = index; i >= 0; i--)
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
