using System;
using System.Collections.Generic;

namespace TryLinkedListStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Parent> families = new List<Parent>();
            List<LinkedParent> list = new List<LinkedParent>();
            LinkedParent tree = new LinkedParent();

            for (int i = 0; i < 3; i++)
            {
                string name = Console.ReadLine();
                string family = Console.ReadLine();
                Parent parent = new Parent(name, family);
                tree.AddParant(parent);
                families.Add(parent);
                list.Add(tree);
            }
            
        }
    }
}
