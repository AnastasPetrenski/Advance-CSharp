using System;
using System.Collections.Generic;
using System.Text;

namespace TryLinkedListStructure
{
    public class Parent
    {
        public Parent(string name, string familyName)
        {
            this.FirstName = name;
            this.LastName = familyName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Parent Next { get; set; }
    }
}
