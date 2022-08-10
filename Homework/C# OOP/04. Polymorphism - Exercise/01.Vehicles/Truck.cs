using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumation)  
            : base(fuelQuantity, fuelConsumation)
        {
        }

        public override string Drive(double distance)
        {
            if (fuelQuantity >= (fuelConsumation + 1.6) * distance)
            {
                this.fuelQuantity -= (fuelConsumation + 1.6) * distance;
                return $"Truck travelled {distance} km";
            }
            else
            {
                return "Truck needs refueling";
            }
        }

        public override void Refuel(double gas)
        {
            fuelQuantity += gas - (0.05 * gas);
        }

        public override string ToString()
        {
            return $"Truck: {fuelQuantity:f2}";
        }
    }
}
