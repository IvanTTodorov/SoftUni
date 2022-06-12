using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string command = Console.ReadLine();
        HashSet<string> carsInParking = new HashSet<string>();

        while (command != "END")
        {
            string[] cars = command.Split(", ");
            string inOrOut = cars[0];
            string numbersCars = cars[1];


            if (inOrOut == "IN")
            {
                carsInParking.Add(numbersCars);
            }
            else if (inOrOut == "OUT")
            {
                carsInParking.Remove(numbersCars);
            }
            command = Console.ReadLine();
        }
        if (carsInParking.Count > 0)
        {
           foreach (var item in carsInParking)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}