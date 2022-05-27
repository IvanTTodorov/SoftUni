using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Vehicles> allVehicles = new List<Vehicles>();
            while (input != "End")
            {
                string[] command = input.Split();

               

                string type = command[0];
                string model = command[1];
                string color = command[2];
                string horsePower = command[3];

                Vehicles vehicle = new Vehicles();

                string typeUpperLetter = char.ToUpper(type[0]) + type.Substring(1);

               vehicle.Type = typeUpperLetter;
                vehicle.Model = model;
                vehicle.Color = color;
                vehicle.HorsePower = horsePower;

                allVehicles.Add(vehicle);

                input = Console.ReadLine();
            }
            while (input != "Close the Catalogue")
            {
                string inputVehicles = input;
                if (allVehicles.Any(x => x.Model == inputVehicles))
                {
                    int index = allVehicles.FindIndex(x => x.Model == inputVehicles);
                    Console.WriteLine(allVehicles[index].ToString());
                }
                input = Console.ReadLine();
            }
            List<Vehicles> cars = allVehicles.Where(x => x.Type == "Car").ToList();
            List<Vehicles> trucks = allVehicles.Where(x => x.Type == "Truck").ToList();
            double horsePowerCars = 0;
            double horsePowerTrucks = 0;


            foreach (var car in cars)
            {
                horsePowerCars += double.Parse(car.HorsePower);
            }
            foreach (var truck in trucks)
            {
                horsePowerTrucks += double.Parse(truck.HorsePower);
            }
            double averageCars = horsePowerCars / cars.Count;
            double averageTrucks = horsePowerTrucks / trucks.Count;

            if (cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:f2}.");
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTrucks:f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:f2}.");
            }


        }
    }
    public class Vehicles
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string HorsePower { get; set; }

        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd();
        }
    }
}