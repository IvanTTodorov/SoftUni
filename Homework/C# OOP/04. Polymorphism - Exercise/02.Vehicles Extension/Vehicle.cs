using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class Vehicle : IVehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
           

        }
        public double TankCapacity
        {
            get => tankCapacity;
            set => tankCapacity = value;
        }
        public double FuelQuantity
        {
            get => fuelQuantity;
            set
            {
                if (value > this.TankCapacity)
                {
                    value = 0;
                }
                fuelQuantity = value;
            }
        }
        public virtual double FuelConsumption
        {
            get => fuelConsumption;
            set => fuelConsumption = value;
        }
      
        public bool IsEmpty { get; set ; }

        public bool CanDrive(double km)
        {
            if (FuelQuantity - (km * fuelConsumption) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Drive(double km)
        {
            if (!CanDrive(km))
            {
                return;
            }
            FuelQuantity -= km * FuelConsumption;
        }

        public virtual void Refuel(double liters)
        {
            ValidateLiters(liters);
            ValidateQuantity(liters);
            
            FuelQuantity += liters;
        } 

        protected void ValidateLiters (double liters )
        {
            if (liters <= 0)
            {
                Console.WriteLine($"Fuel must be a positive number");
                return;
            }
        } 

        protected void ValidateQuantity (double liters)
        {
            if (fuelQuantity + liters > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {liters} fuel in the tank");
                return;
            }
        }
    }
}
