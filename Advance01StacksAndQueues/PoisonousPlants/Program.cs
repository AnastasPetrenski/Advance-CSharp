using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PoisonousPlants
{
    class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            List<int> plants = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> plantsToBeRemoved = new Stack<int>();

            int dayAfterWhichPlantsRemainAlive = 0;
            int plantsAlive = plants.Count;
            for (int k = 0; k < plantsCount; k++)
            {
                for (int i = 0; i < plants.Count - 1; i++)
                {
                    if (plants[i + 1] > plants[i])
                    {
                        plantsToBeRemoved.Push(i + 1);
                    }
                }
                

                dayAfterWhichPlantsRemainAlive++;

                if (plantsToBeRemoved.Count > 0)
                {
                    while (plantsToBeRemoved.Count > 0)
                    {
                        var indexOfdeathPlant = plantsToBeRemoved.Pop();
                        plants.RemoveAt(indexOfdeathPlant);
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(dayAfterWhichPlantsRemainAlive - 1);
        }
    }
}
