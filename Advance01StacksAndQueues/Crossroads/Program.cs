using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLigthDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string command = string.Empty;
            Queue<string> cars = new Queue<string>();
            int carPassed = 0;
            while ((command = Console.ReadLine()) != "END")
            {
                int greenLight = greenLigthDuration;
                int freeWindow = freeWindowDuration;

                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    while (greenLight > 0)
                    {
                        if (cars.TryDequeue(out var carLength))
                        {
                            greenLight -= carLength.Length;
                        }
                        else
                        {
                            break;
                        }

                        if (greenLight > 0)
                        {
                            carPassed++;
                        }
                        else
                        {
                            freeWindow += greenLight;
                            if (freeWindow < 0)
                            {
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{carLength} was hit at {carLength[carLength.Length + freeWindow]}.");
                                return;
                            }
                            else
                            {
                                carPassed++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine($"Everyone is safe.");
            Console.WriteLine($"{carPassed} total cars passed the crossroads.");
        }
    }
}
