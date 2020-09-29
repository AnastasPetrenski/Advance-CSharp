using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int carsNumber = int.Parse(Console.ReadLine());
            HashSet<Car> cars = new HashSet<Car>();
            for (int i = 0; i < carsNumber; i++)
            {
                string[] input = ReadAndConvertInput();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionPerKilometer = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = ReadAndConvertInput(command);
                string model = input[1];
                double distance = double.Parse(input[2]);
                foreach (var car in cars)
                {
                    if (car.Model == model)
                    {
                        car.DriveCar(distance);
                        break;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString()); 
            }
        }

        static string[] ReadAndConvertInput()
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return input;
        }

        static string[] ReadAndConvertInput(string command)
        {
            string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return input;
        }
    }
}
