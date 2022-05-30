using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> currentCars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split();


                Car car = new Car(text[0], int.Parse(text[1]), int.Parse(text[2]), int.Parse(text[3]), text[4]);
                currentCars.Add(car);
            }

            string command = Console.ReadLine();
            List<Car> filteredCars = currentCars.Where(x => x.CargoType == command).ToList();

            foreach (var car in filteredCars)
            {
                if (command == "fragile" && car.CargoWeight < 1000)
                {
                    Console.WriteLine(String.Join(Environment.NewLine, car));
                }
                else if (command == "flamable" && car.EnginePower > 250)
                {
                    Console.WriteLine(String.Join(Environment.NewLine, car));
                }
            }

        }
        }

        public class Car
        {
            public string Model { get; set; }
            public int EngineSpeed { get; set; }
            public int EnginePower { get; set; }
            public int CargoWeight { get; set; }
            public string CargoType { get; set; }

            public Car(string model, int engineSpeed, int enginePower, int cargoWeight, string cargoType) 
            {
                Model = model; 
                EngineSpeed = engineSpeed;
                EnginePower = enginePower;
                CargoWeight = cargoWeight;
                CargoType = cargoType;
            }

            public override string ToString()
            {
                return $"{Model}";
            }

        }
} 