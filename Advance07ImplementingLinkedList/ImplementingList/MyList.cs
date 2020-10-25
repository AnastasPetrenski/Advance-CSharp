using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ImplementingList
{
    public class MyList<T> : IEnumerable<int>
    {
        private int index = 0;
        private int capacity;
        private int[] data;

        public MyList()
            :this(4)
        {

        }

        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
        }

        public int Count { get { return this.index; } } 

        public void Clear()
        {
            this.index = 0;

            this.data = new int[this.capacity];
        }

        public void Add(int element)
        {
            if (this.Count == data.Length - 1)
            {
                this.Resize();
            }
            this.data[this.index] = element;

            index++;
        }

        public int RemoveAt(int indexToBeRemoved)
        {
            this.ValidateIndex(indexToBeRemoved);
            int element = this.data[indexToBeRemoved];
            for (int i = indexToBeRemoved; i < this.Count; i++)
            {
                this.data[i] = this.data[i + 1];
            }
            
            this.index--;
            
            return element;
        }

        public void ReverseMyList()
        {
            for (int i = 0; i < this.index / 2; i++)
            {
                var temp = this.data[i];
                this.data[i] = this.data[this.index - 1 - i];
                this.data[this.index - 1 - i] = temp;
            }
           }

        public void Swap(int first, int second)
        {
            this.ValidateIndex(first);
            this.ValidateIndex(second);

            var temp = this.data[first];
            this.data[first] = this.data[second];
            this.data[second] = temp;
        }

        public bool Contains(int element)
        {
            foreach (var item in this.data)
            {
                if (item == element)
                {
                    return true;
                }
            }

            return false;
        }

        private void ValidateIndex(int index)
        {
            if (index >= 0 && index < this.index)
            {
                return;
            }
            var message = this.index == 0
                ? "The list is empty"
                : $"The list has {this.index} elements and it is zero based.";
            throw new Exception($"Index out of range. {message}");
        }

        private void Resize()
        {

            var newCapacity = data.Length * 2;

            var newData = new int[newCapacity];

            for (int i = 0; i < this.data.Length; i++)
            {
                newData[i] = this.data[i];
            }

            this.data = newData;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return this.data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
