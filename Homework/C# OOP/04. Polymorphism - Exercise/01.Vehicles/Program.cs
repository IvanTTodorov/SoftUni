using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args) {
             
            string[] carInfo = Console.ReadLine().Split();
            string[] truckInfo = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carInfo[1]), double.Parse(carInfo[2]));
        Vehicle truck = new Truck(double.Parse(truckInfo[1]), double.Parse(truckInfo[2]));

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();

                if (command[1] == "Car")
                {
                    if (command[0] == "Drive")
                    {
                        Console.WriteLine(car.Drive(double.Parse(command[2]))); ;
                    } 
                    else if (command[0] == "Refuel")
                    {
                        car.Refuel(double.Parse(command[2]));
                    }
                } 
                else if (command[1] == "Truck")
                {
                    if (command[0] == "Drive")
                    {
                        Console.WriteLine(truck.Drive(double.Parse(command[2])));
                    }
                    else if (command[0] == "Refuel")
                    {
                        truck.Refuel(double.Parse(command[2]));
                    }
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());

        }
    }
}
