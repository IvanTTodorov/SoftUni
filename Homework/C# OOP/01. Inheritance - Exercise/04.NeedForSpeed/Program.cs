using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace NeedForSpeed
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(100, 105.5);
            Vehicle raceMotocycle = new RaceMotorcycle(100, 105.5);
            car.Drive(1);
            raceMotocycle.Drive(1);
            
        }
    }
}