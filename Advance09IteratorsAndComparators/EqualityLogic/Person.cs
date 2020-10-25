using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = 1;

            if (other != null)
            {
                result = this.Name.CompareTo(other.Name);
                if (result == 0)
                {
                    result = this.Age.CompareTo(other.Age);
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Person;

            if (item == null)
            {
                return false;
            }

            return this.CompareTo(item) == 0;
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode();
        }
    }
}
