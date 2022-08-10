using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        protected Vehicle(double fuelQuantity, double fuelConsumation)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumation = fuelConsumation;
        }

        public double fuelQuantity { get; set; }
        public double fuelConsumation { get; set; }

        public abstract string Drive(double distance);

        public abstract void Refuel(double gas );

    }
}
