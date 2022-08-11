using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption,tankCapacity)
        {
        }

        public override double FuelConsumption
            => base.FuelConsumption + 1.6;

        public override void Refuel(double liters)
        {
            ValidateLiters(liters);
            ValidateQuantity(liters); 

            liters *= 0.95;
            base.Refuel(liters);
        }
    }
}
     
