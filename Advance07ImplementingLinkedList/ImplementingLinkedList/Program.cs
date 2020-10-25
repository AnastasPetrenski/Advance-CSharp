using System;
using System.Collections.Generic;
using System.Linq;

namespace ImplementingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            Action<int> action = x => Console.WriteLine(x);  

            lista.ForEach(action);

            LinkedList list = new LinkedList();

            for (int i = 0; i < 3; i++)
            {
                list.AddHead(new Node(i));
            }

            list.Pop();
            list.PrintList();
            list.PrintReverseList();
            list.Pop();
        }

    }
}
