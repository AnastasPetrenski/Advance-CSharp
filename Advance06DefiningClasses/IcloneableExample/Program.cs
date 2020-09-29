using System;
using IcloneableExample;

namespace IcloneableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dude Bill = new Dude();
            Bill.Name = "Bill";
            Bill.LeftShoe = new Shoe();
            Bill.RightShoe = new Shoe();
            Bill.LeftShoe.Color = Bill.RightShoe.Color = "Blue";
            Dude Ted = Bill.Clone() as Dude;
            Ted.Name = "Ted";
            Ted.LeftShoe.Color = Ted.RightShoe.Color = "Red";
            Console.WriteLine(Bill.ToString());
            Console.WriteLine(Ted.ToString());
        }
    }

    public struct Shoe : ICloneable
    {
        public string Color;
        #region ICloneable Members
        public object Clone()
        {
            Shoe newShoe = new Shoe();
            newShoe.Color = Color.Clone() as string;
            return newShoe;
        }
        #endregion
    }

    public class Dude : ICloneable
    {
        public string Name;
        public Shoe RightShoe;
        public Shoe LeftShoe;
        public object Clone()
        {
            Dude newPerson = new Dude();
            newPerson.Name = Name;
            newPerson.LeftShoe = LeftShoe; //.Clone() as Shoe;
            newPerson.RightShoe = RightShoe; //.Clone() as Shoe;
            return newPerson;
        }
        public override string ToString()
        {
            return (Name + " : Dude!, I have a " + RightShoe.Color + " shoe on my right foot, and a " + LeftShoe.Color + " on my left foot.");
        }
    }
}
