using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();
            string[] busInfo = Console.ReadLine().Split();

            IVehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]), double.Parse(carInfo[3]));
            IVehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]), double.Parse(truckInfo[3]));
            IVehicle bus = new Bus(double.Parse(busInfo[1]), double.Parse(busInfo[2]), double.Parse(busInfo[3]));

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine().Split();
                string action = inputInfo[0];
                string vehicle = inputInfo[1];
                double value = double.Parse(inputInfo[2]);

                if (action == "Drive")
                {
                    if (vehicle == "Car")
                    {
                        if (car.CanDrive(value))
                        {
                            car.Drive(value);
                            Console.WriteLine($"Car travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Car needs refueling");
                        }
                    }
                    else if (vehicle == "Truck")
                    {
                        if (truck.CanDrive(value))
                        {
                            truck.Drive(value);
                            Console.WriteLine($"Truck travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Truck needs refueling");
                        }
                    }
                    else if (vehicle == "Bus")
                    {
                        bus.IsEmpty = false;
                        if (bus.CanDrive(value))
                        {
                            bus.Drive(value);
                            Console.WriteLine($"Bus travelled {value} km");
                        }
                        else
                        {
                            Console.WriteLine("Bus needs refueling");
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    if (vehicle == "Car")
                    {
                        car.Refuel(value);
                    }
                    else if (vehicle == "Truck")
                    {
                        truck.Refuel(value);
                    }
                    else if (vehicle == "Bus")
                    {
                        bus.Refuel(value);
                    }
                }

                else if (action == "DriveEmpty")
                {
                    bus.IsEmpty = true;
                    if (bus.CanDrive(value))
                    {
                        bus.Drive(value);
                        Console.WriteLine($"Bus travelled {value} km");
                    }
                    else
                    {
                        Console.WriteLine("Bus needs refueling");
                    }
                }

               

            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}




