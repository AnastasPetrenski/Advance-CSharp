using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace IEnumerableExample
{
    public class Numbers
    {
        private int[] data;

        public Numbers(int[] numbers)
        {
            this.data = numbers;
        }

        public int Count { get { return this.data.Length; } }
    }
}
