
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer,double travelledDistance)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = travelledDistance;
        }
        public void Drive (double amountOfKm)
        {
            if (FuelAmount >= amountOfKm *FuelConsumptionPerKilometer)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= amountOfKm * (FuelConsumptionPerKilometer);
            } 
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }

}
