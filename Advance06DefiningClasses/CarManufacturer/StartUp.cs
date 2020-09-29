namespace CarManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Tire[]> tires = new List<Tire[]>();
            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] input = ConvertInput(command);
                var tire = new Tire[]
                {
                    new Tire(int.Parse(input[0]), double.Parse(input[1])),
                    new Tire(int.Parse(input[2]), double.Parse(input[3])),
                    new Tire(int.Parse(input[4]), double.Parse(input[5])),
                    new Tire(int.Parse(input[6]), double.Parse(input[7])),
                };
                tires.Add(tire);
            }

            List<Engine> engines = new List<Engine>();
            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] input = ConvertInput(command);
                var engine = new Engine(int.Parse(input[0]), double.Parse(input[1]));
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();
            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] input = ConvertInput(command);
                Car car = new Car();
                car.Make = input[0];
                car.Model = input[1];
                car.Year = int.Parse(input[2]);
                car.FuelQuantity = double.Parse(input[3]);
                car.FuelConsumption = double.Parse(input[4]);
                car.Tires = tires[int.Parse(input[5])];
                car.Engine = engines[int.Parse(input[6])];

                cars.Add(car);
            }

            cars = cars
                 .Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Pressure) >= 9 && x.Tires.Sum(y => y.Pressure) <= 10).ToList();

            foreach (var item in cars)
            {
                item.Drive(20);
                Console.WriteLine(item.WhoAmI());
            }

            /* ###################################### */

            //    string make = Console.ReadLine();
            //    string model = Console.ReadLine();
            //    int year = int.Parse(Console.ReadLine());
            //    double fuelQuantity = double.Parse(Console.ReadLine());
            //    double fuelConsumption = double.Parse(Console.ReadLine());

            //    Car firstCar = new Car();
            //    Car secondCar = new Car(make, model, year);
            //    Car thirdCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

            /* ###################################### */

            //var tires = new Tire[]
            //{
            //    new Tire(1, 2.5),
            //    new Tire(1, 2.1),
            //    new Tire(2, 0.5),
            //    new Tire(2, 2.3),
            //};

            //var engine = new Engine(560, 6300.00);

            //var car = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);
        }

        static string[] ConvertInput(string command)
        {
            string[] input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return input;
        }
    }
}
