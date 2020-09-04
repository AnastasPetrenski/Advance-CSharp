using System;
using System.Collections.Generic;

namespace _06_ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            HashSet<string> cars = new HashSet<string>();
            while ((command = Console.ReadLine()) != "END")
            {
                string[] input = command
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string action = input[0];
                string carPlate = input[1];

                if (action == "IN")
                {
                    cars.Add(carPlate);
                }
                else if (action == "OUT")
                {
                    cars.Remove(carPlate);
                }
            }

            if (cars.Count > 0)
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            
        }
    }
}
