using System;

namespace GenerateVectorsRecursivly
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 3;
            int[] vector = new int[size];
            Gen01(size - 1, vector);
        }

        static void Gen01(int index, int[] vector)
        {
            if (index == -1)
            {
                Console.WriteLine(string.Join("", vector));
            }
            else
            {
                for (int i = 0; i <= 2; i++)
                {
                    vector[index] = i+1;
                    Gen01(index - 1, vector);
                }
            }
        }
    }
}
