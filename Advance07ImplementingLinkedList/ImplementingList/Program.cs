using System;

namespace ImplementingList
{
    public class Program
    {
        static void Main(string[] args)
        {
            int capacity = 12;
            MyList<int> list = new MyList<int>(capacity);
            for (int i = 0; i < capacity; i++)
            {
                list.Add(i+1);
            }

            PrintList(list);

            list.RemoveAt(1);
            //list.RemoveAt(100); exeption
            PrintList(list);

            if (list.Contains(3))
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

            list.ReverseMyList();

            PrintList(list);
            list.Clear();
        }

        public static void PrintList(MyList<int> list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"elements: {list.Count}");
        }
    }
}
