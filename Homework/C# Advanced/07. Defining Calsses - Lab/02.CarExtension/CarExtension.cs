using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace CarManufacturer
{

    public class StartUp
    {
        static void Main(string[] args)
        {
            Car cars = new Car();
            cars.Make = "Audi";
            cars.Model = "A6";
            cars.Year = 2000;
            cars.FuelQuantity = 100;
            cars.FuelConsumption = 10;
            cars.Drive(2000); 
            Console.WriteLine(cars.WhoAmI());


        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public string WhoAmI()
        {
            return $"Make: {this.Make}" + Environment.NewLine +
             $"Model: {this.Model}" + Environment.NewLine +
             $"Year: {this.Year}" + Environment.NewLine +
             $"Fuel: {this.FuelQuantity:F2}";
        }
        public void Drive(double distance)
        {
            double consumption = distance * (FuelConsumption / 100.0); 
            if(consumption <= FuelQuantity)
            {
                FuelQuantity = FuelQuantity - consumption; 
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                 
            }
        }
    }
}