using System;
using System.Linq;

namespace _02_ArrayTest
{
    public class Program
    {
        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = new long[sizeOfArray];
            long[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToArray();

            for (int i = 0; i < sizeOfArray; i++)
            {
                array[i] = input[i];
            }

            string command = Console.ReadLine();

            while (!command.Equals("stop"))
            {
                string[] stringParams = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int[] args = new int[2];
                string action = stringParams[0];

                if (action.Equals("add") ||
                    action.Equals("subtract") ||
                    action.Equals("multiply"))
                {

                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    array = PerformAction(array, stringParams[0], args);
                }
                else if (stringParams[0].Equals("lshift") || stringParams[0].Equals("rshift"))
                {
                    switch (stringParams[0])
                    {
                        case "lshift":
                            
                            ArrayShiftLeft(array);
                            break;
                        case "rshift":
                            ArrayShiftRight(array);
                            break;
                    }
                }


                PrintArray(array);
                Console.WriteLine();

                command = Console.ReadLine();
            }
        }

        static long[] PerformAction(long[] arr, string action, int[] args)
        {
            long[] array = arr;
            int pos = args[0] - 1;
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    array[pos] *= value;
                    break;
                case "add":
                    array[pos] += value;
                    break;
                case "subtract":
                    array[pos] -= value;
                    break;
                
            }

            return array;
        }

        private static long[] ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;

            return array;
        }

        private static long[] ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;

            return array;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
    }
}
