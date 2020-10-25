using System;
using System.Collections.Generic;
using System.Text;

namespace TryLinkedListStructure
{
    public class LinkedParent
    {
        public Parent Head { get; set; }

        public void AddParant(Parent parent)
        {
            parent.Next = Head;
            this.Head = parent;
        }
    }
}
