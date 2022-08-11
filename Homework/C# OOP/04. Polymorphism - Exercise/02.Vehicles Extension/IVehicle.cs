using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public interface IVehicle
    {
        public double FuelQuantity  { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public bool IsEmpty { get; set; }
        public bool CanDrive(double km);
        void Drive(double km);
        void Refuel(double liters);
    }
}
