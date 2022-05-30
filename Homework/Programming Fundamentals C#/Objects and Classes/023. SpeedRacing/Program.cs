using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> newCar = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string model = command[0];
                double fuelAmount = double.Parse(command[1]);
                double fuelConsumptionPerKm = double.Parse(command[2]);

                Car car = new Car(model, fuelAmount, fuelConsumptionPerKm);
                newCar.Add(car);
            }
            string[] input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                int km = int.Parse(input[2]);
                newCar.Find(x => x.Model == input[1]).CalculateCar(km);




                input = Console.ReadLine().Split();
            }

            Console.WriteLine(String.Join(Environment.NewLine, newCar));
        }
    }
    public class Car
    {


        public string Model { get; set; }
        public double FuelAmount { get; set; }

        public double FuelConsumptionPerKm { get; set; }
        public int DistanceTravel { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
        }
        public void CalculateCar(int km)
        {
            if (FuelAmount / FuelConsumptionPerKm >= km)
            {
                FuelAmount -= (km * FuelConsumptionPerKm);
                DistanceTravel += km; 
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {DistanceTravel}";
        }


    }
}
