using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(double fuelQuantity, double fuelConsumation)  
            : base(fuelQuantity, fuelConsumation)
        {
        }


        public override string Drive(double distance)
        {
            if (fuelQuantity >= (fuelConsumation + 0.9) * distance)
            {
                this.fuelQuantity -= (fuelConsumation + 0.9) * distance;
                return $"Car travelled {distance} km";
            }
            else
            {
                return "Car needs refueling";
            }
        }

        public override void Refuel(double gas)
        {
            fuelQuantity += gas;
        }

        public override string ToString()
        {
            return $"Car: {fuelQuantity:f2}";
        }
    }
}
