using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class MyList<T> : IEnumerable<T>
    {
        private int index;

        public MyList()
        {
            this.index = 0;
            this.People = new List<T>();
        }

        public List<T> People { get; set; }

        public void Add(T person)
        {

            People.Add(person);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < People.Count; i++)
            {
                yield return People[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
