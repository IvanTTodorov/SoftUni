using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Cars> cars = new List<Cars>();
            List<Trucks> trucks = new List<Trucks>();
            while (input != "end")
            {
                string[] command = input.Split('/');

                string vehicle = command[0];
                string brand = command[1];
                string model = command[2];
                string weightAndHP = command[3];

                if(vehicle == "Car")
                {
                    Cars car = new Cars ();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = weightAndHP;

                    cars.Add(car);
                } else if(vehicle == "Truck")
                {
                    Trucks truck = new Trucks();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weightAndHP;
                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }
            List <Cars> filteredCars = cars.OrderBy(car => car.Brand).ToList();
            List<Trucks> filteredTrucks = trucks.OrderBy(truck => truck.Brand).ToList();
            Console.WriteLine("Cars:");
            foreach (Cars car in filteredCars)
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (Trucks truck in filteredTrucks)
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }
    class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Trucks
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

    }
     
   

}