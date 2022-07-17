using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace CarManufacturer
{

   public class StartUp
    {
  
    static void Main(string[] args)
        {
            Car cars = new Car();
            cars.Make = "VW";
            cars.Model = "MK3";
            cars.Year = 1992;

            Console.WriteLine($"Make: {cars.Make}");
            Console.WriteLine($"Model: {cars.Model}");
            Console.WriteLine($"Year: {cars.Year}");
        }
    }
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}