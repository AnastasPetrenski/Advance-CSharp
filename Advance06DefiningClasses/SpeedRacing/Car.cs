using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SpeedRacing
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance = 0;

        public Car(string model, double amount, double consumption)
        {
            this.Model = model;
            this.FuelAmount = amount;
            this.FuelConsumptionPerKilometer = consumption;
            this.Travelleddistance = travelledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double Travelleddistance { get; set; }

        public void DriveCar(double distance)
        {
            var neededFuel = this.FuelConsumptionPerKilometer * distance;
            if (this.FuelAmount >= neededFuel)
            {
                this.FuelAmount -= neededFuel;
                this.Travelleddistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{this.Model} {this.FuelAmount:f2} {this.Travelleddistance}"; 
        }
    }
}
