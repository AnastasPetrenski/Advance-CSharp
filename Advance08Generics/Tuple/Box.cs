using System;
using System.Collections.Generic;
using System.Text;

namespace Tuple
{
    public class Box<T1, T2>
    {
        private T1 itemOne;
        private T2 itemTwo;

        public Box(T1 itemOne, T2 itemTwo)
        {
            this.itemOne = itemOne;
            this.itemTwo = itemTwo;
        }

        public override string ToString()
        {
            return $"{itemOne} -> {itemTwo}";
        }
    }
}
