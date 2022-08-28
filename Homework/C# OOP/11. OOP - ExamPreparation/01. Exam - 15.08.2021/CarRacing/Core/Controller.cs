using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarRacing.Core
{
    public class Controller : IController
    {

        private CarRepository cars; 
        private RacerRepository racers;
        private IMap map;

        public Controller()
        {
            cars = new CarRepository();
            racers = new RacerRepository();
            map = new Map(); 
        }

        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            ICar car;
            if (type == "SuperCar")
            {
                 car = new SuperCar(make, model, VIN, horsePower);
            }
            else if(type == "TunedCar")
            {
               car = new TunedCar(make, model, VIN, horsePower);  
            }
            else
            {
                throw new ArgumentException("Invalid car type!");
            }
            cars.Add(car);
            return $"Successfully added car {car.Make} {car.Model} ({car.VIN}).";
        }
        public string AddRacer(string type, string username, string carVIN)
        {
            ICar car = cars.FindBy(carVIN);
            IRacer racer;

            if (cars.FindBy(carVIN) == null)
            {
                throw new ArgumentException("Car cannot be found!");
            }
          
            if (type == "ProfessionalRacer")
            {
                racer = new ProfessionalRacer(username, car);
            }

            else if(type == "StreetRacer")
            {
               racer = new StreetRacer(username, car);
            }

           else 
            {
                throw new ArgumentException("Invalid racer type!");
            }
            racers.Add(racer);
            return $"Successfully added racer {racer.Username}.";

        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            IRacer racer = racers.FindBy(racerOneUsername);
            IRacer racer2 = racers.FindBy(racerTwoUsername);
            if (racer == null)
            {
                throw new ArgumentException($"Racer {racerOneUsername} cannot be found!"); 
            }
            else if( racer2 == null)
            {
                throw new ArgumentException($"Racer {racerTwoUsername} cannot be found!");
            }

                return map.StartRace(racer, racer2);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();

            var racers = this.racers.Models.OrderByDescending(x => x.DrivingExperience)
                .ThenBy(x => x.Username); 

            foreach(var racer in racers)
            {
                sb.AppendLine(racer.ToString()); 
            }
            return sb.ToString().TrimEnd(); 
        }
    }
}
