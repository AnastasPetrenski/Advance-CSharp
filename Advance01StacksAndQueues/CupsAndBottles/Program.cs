using System;
using System.Collections.Generic;
using System.Linq;

namespace CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            int wastedWaterLitters = 0;
            while (true)
            {
                if (cups.TryDequeue(out var cupCapacity))
                {
                    if (bottles.TryPop(out var bottleSize))
                    {
                        if (bottleSize >= cupCapacity)
                        {
                            wastedWaterLitters += (bottleSize - cupCapacity);
                        }
                        else
                        {
                            while (true)
                            {
                                cupCapacity -= bottleSize;
                                if (cupCapacity > 0)
                                {
                                    if (bottles.TryPop(out bottleSize))
                                    {
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Write($"Cups: {cupCapacity} ");
                                        while (cups.Any())
                                        {
                                            Console.Write($"{cups.Dequeue()} ");
                                        }
                                        Console.WriteLine();
                                        Console.WriteLine($"Wasted litters of water: {wastedWaterLitters}");
                                        return;
                                    }
                                }
                                else
                                {
                                    wastedWaterLitters += Math.Abs(cupCapacity);
                                    break;
                                }

                            }
                        }
                    }
                    else
                    {
                        Console.Write($"Cups: {cupCapacity} ");
                        while (cups.Any())
                        {
                            Console.Write($"{cups.Dequeue()} ");
                        }
                        Console.WriteLine();
                        Console.WriteLine($"Wasted litters of water: {wastedWaterLitters}");
                        break;
                    }
                }
                else
                {
                    //if(bottles.Count > 0) 
                    Console.Write($"Bottles: ");
                    while (bottles.Any())
                    {
                        Console.Write($"{bottles.Pop()} ");
                    }
                    //else{"Bottles: 0"}
                    Console.WriteLine();
                    Console.WriteLine($"Wasted litters of water: {wastedWaterLitters}");
                    break;
                }
            }
        }
    }
}
