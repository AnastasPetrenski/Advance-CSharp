using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> list;

        public Box()
        {
            this.list = new Stack<T>();
        }

        public int Count => this.list.Count;

        public void Add(T item)
        {
            this.list.Push(item);
        }

        public T Remove()
        {
            return this.list.Pop();
        }
    }
}
