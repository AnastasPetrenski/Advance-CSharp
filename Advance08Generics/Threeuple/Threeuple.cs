using System;
using System.Collections.Generic;
using System.Text;

namespace Threeuple
{
    public class Threeuple<T1, T2, T3> 
    {
        public Threeuple(T1 one, T2 two, T3 three)
        {
            this.ItemOne = one;
            this.ItemTwo = two;
            this.ItemThree = three;
        }

        public T1 ItemOne { get; set; }
        public T2 ItemTwo { get; set; }
        public T3 ItemThree { get; set; }

        public override string ToString()
        {
            return $"{this.ItemOne} -> {this.ItemTwo} -> {this.ItemThree}";
        }
    }
}
