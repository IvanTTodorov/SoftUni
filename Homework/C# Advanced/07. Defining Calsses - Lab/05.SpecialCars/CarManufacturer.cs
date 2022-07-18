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
            string text = Console.ReadLine();
            Dictionary<int,Tire[]> carTires = new Dictionary<int,Tire[]>();
            Dictionary<int, Engine> engines = new Dictionary<int, Engine>(); 
            List<Car> allCars = new List<Car>();    
            int tyresNumber = 0;
            int EngineNumbers = 0;
            while (text != "No more tires")
            {
                string[] command = text.Split(); 
                Tire[] tire = new Tire[]
            {
                new Tire(int.Parse(command[0]), double.Parse(command[1])),
                new Tire(int.Parse(command[2]), double.Parse(command[3])),
                new Tire(int.Parse(command[4]), double.Parse(command[5])),
                new Tire(int.Parse(command[6]), double.Parse(command[7]))
            };
                carTires.Add(tyresNumber, tire);
                tyresNumber++;

                text = Console.ReadLine();
            }
             
            
            string text2 = Console.ReadLine(); 
            while (text2 != "Engines done")
            {
                string[] command = text2.Split();
                int horsePower = int.Parse(command[0]);
                double cubicCapacity = double.Parse(command[1]);

                Engine engine = new Engine(horsePower, cubicCapacity);
                engines.Add(EngineNumbers, engine);
                EngineNumbers++;

                text2 = Console.ReadLine();
            }


            string text3 = Console.ReadLine();
            while (text3 != "Show special")
            {
                string[] command = text3.Split();
                int indexTires = int.Parse(command[5]);
                int indexEngine = int.Parse(command[6]);

                Car car = new Car(command[0], command[1], int.Parse(command[2]), int.Parse(command[3])
                    , int.Parse(command[4]), engines[indexEngine], carTires[indexTires]);

                double SumTirePressure = car.Tires[0].Pressure + car.Tires[1].Pressure + car.Tires[2].Pressure + car.Tires[3].Pressure;
                if (car.Year >= 2017 && car.Engine.HorsePower > 330 && SumTirePressure > 9 && SumTirePressure < 10)
                {
                    car.FuelQuantity -= 20 * (car.FuelConsumption / 100);
                    allCars.Add(car);
                }
                text3 = Console.ReadLine();

            }

            foreach (var car in allCars)
            {
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }

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
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }
    }

}
