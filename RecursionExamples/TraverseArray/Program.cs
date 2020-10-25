using System;

namespace TraverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3 };

            Traverse(array, 0);

            Console.WriteLine(SumTraverse(array, 0));
        }

        private static int SumTraverse(int[] array, int index)
        {
            if (index >= array.Length)
            {
                return 0;
            }

            int result = array[index] + SumTraverse(array, index + 1);

            return result;
        }

        private static void Traverse<T>(T[] collection, int index)
        {
            if (index >= collection.Length)
            {
                return;
            }

            Console.WriteLine(collection[index]);

            Traverse(collection, index + 1);
        }
    }
}
