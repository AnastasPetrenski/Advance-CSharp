using System;
using System.Collections.Generic;
using System.Text;

namespace ImplementingLinkedList
{
    public class LinkedList
    {
        public Node Head { get; set; }

        public Node Tail { get; set; }

        public void AddHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
        }

        public Node Pop()
        {
            var oldHead = Head;
            Head = Head.Next;
            return oldHead;
        }

        public void PrintList()
        {
            this.MyListForEach(node => Console.WriteLine(node.Value));
        }

        public void PrintReverseList()
        {
            Node currentNode = Tail;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);   
                currentNode = currentNode.Previous;
            }
        }

        public void MyListForEach(Action<Node> action)
        {
            Node currentNode = Head;
            while (currentNode != null)
            {
                action(currentNode);
                currentNode = currentNode.Next;
            }
        }

        public override string ToString()
        {
            return $"Head = Node{this.Head.Value}";
        }
    }
}
