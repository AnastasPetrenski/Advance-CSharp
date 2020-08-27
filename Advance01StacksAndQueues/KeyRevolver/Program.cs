using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBarrelSize = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));
            List<int> reverseInputBullet = Console.ReadLine()
                .Split()
                .Select(int.Parse).ToList();
            reverseInputBullet.Reverse();
            Stack<int> locks = new Stack<int>(reverseInputBullet);
            int intelligence = int.Parse(Console.ReadLine());
            int bulletCounter = 0;
            while (true)
            {
                int bulletSize = 0;
                int lockSize = 0;
                if(bullets.TryPop(out bulletSize))
                {
                    if (locks.TryPop(out lockSize))
                    {
                        if (lockSize >= bulletSize)
                        {
                            Console.WriteLine("Bang!");
                        }
                        else
                        {
                            Console.WriteLine("Ping!");
                            locks.Push(lockSize);
                        }
                        bulletCounter++;
                        if (bulletCounter % gunBarrelSize == 0 && bullets.Count > 0)
                        {
                            Console.WriteLine("Reloading!");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{bullets.Count + 1} bullets left. Earned ${intelligence - (bulletCounter * bulletPrice)}");
                        break;
                    }
                }
                else
                {
                    if (locks.Count > 0)
                    {
                        Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{bullets.Count} bullets left. Earned ${intelligence - (bulletCounter * bulletPrice)}");
                        break;
                    }
                }
            }
        }
    }
}
