using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpNumbers = int.Parse(Console.ReadLine());
            Queue<Pump> pumps = new Queue<Pump>();
            for (int i = 0; i < pumpNumbers; i++)
            {
                List<int> info = Console.ReadLine().Split().Select(int.Parse).ToList();
                Pump pump = new Pump(info[0], info[1]);
                pumps.Enqueue(pump);
            }

            for (int i = 0; i < pumps.Count; i++)
            {
                var currPomp = pumps.Peek();
                if (currPomp.PumpFuelYield - currPomp.DistanceNextPomp > 0)
                {
                    if (TryCirclingAllPumps(pumps))
                    {
                        Console.WriteLine(i);
                        return;
                    }
                    else
                    {
                        var rotationOfStartingPumpPosition = pumps.Dequeue();
                        pumps.Enqueue(rotationOfStartingPumpPosition);
                    }
                }
                else
                {
                    var rotationOfStartingPumpPosition = pumps.Dequeue();
                    pumps.Enqueue(rotationOfStartingPumpPosition);
                }
            }
        }

        public static bool TryCirclingAllPumps(Queue<Pump> pumps)
        {
            int fuelAmount = 0;
            bool isDone = true;

            foreach (var pump in pumps)
            {
                fuelAmount += pump.PumpFuelYield;
                fuelAmount -= pump.DistanceNextPomp;
                if (fuelAmount < 0)
                {
                    isDone = false;
                    break;
                }
            }

            return isDone;
        }
    }

    public class Pump
    {
        public int PumpFuelYield { get; set; }
        public int DistanceNextPomp { get; set; }

        public Pump(int fuel, int distance)
        {
            this.PumpFuelYield = fuel;
            this.DistanceNextPomp = distance;
        }


    }
}
