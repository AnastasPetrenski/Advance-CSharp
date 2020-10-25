using System;

namespace GenericArrayCreator
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] strings = ArrayCreator.Create(5, "T");
            int[] ints = ArrayCreator.Create(5, 10);
        }
    }
}
