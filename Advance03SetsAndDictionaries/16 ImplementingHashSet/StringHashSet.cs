using System;
using System.Collections.Generic;
using System.Text;

namespace _16_ImplementingHashSet
{
    public class StringHashSet
    {
        private SetElement[] array;

        //constructor
        public StringHashSet(int capacity = 80)
        {
            array = new SetElement[capacity];
        }

        public void Add(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[index] = new SetElement() { Keys = new List<string>() { key } };
            }

            ////above example in one line divided to 3 parts
            //var list = new SetElement();  //instantiating new object SetElement()
            //list.Keys = new List<string>() { "element" }; //instantiating new List() to the object list
            //list.Keys.Add("elements"); //adding an element to the instance
            
        }

        private int HashFunction(string key)
        {
            int asciiResult = key[0] << 5 | key[key.Length - 1] >> 4;
            return asciiResult % array.Length;
        }

        public bool Contains(string key)
        {
            int index = HashFunction(key);

            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Keys.Count; i++)
                {
                    if (array[index].Keys[i] == key)
                    {
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
