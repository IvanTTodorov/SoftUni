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
            Engine engine = new Engine(200, 2000);
            Tire[] tires = new Tire[]
            {
                new Tire (2021, 1.25),
            new Tire(2021, 1.23),
            new Tire(2020, 1.24),
            new Tire(2020, 1.24)
        };

            Car car = new Car("Audi", "A6", 1999, 200, 10, engine, tires);

        }
    }

    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }

        public Tire[] Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelQuantity;
            Engine = engine;
            Tires = tires;
        }
    }
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }
    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}