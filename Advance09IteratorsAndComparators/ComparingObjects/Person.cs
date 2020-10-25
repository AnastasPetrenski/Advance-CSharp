using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person()
        {
            
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person chosen)
        {
            int result = 1;
            if (this.Name == chosen.Name)
            {
                if (this.Age == chosen.Age)
                {
                    if (this.Town == chosen.Town)
                    {
                        result = 0;
                    }
                }
            }

            return result;
        }

        public override bool Equals(object obj)
        {
            if (obj is Person person)
            {
                return this.CompareTo(person) == 0;
            }
            return false;
        }
    }
}
