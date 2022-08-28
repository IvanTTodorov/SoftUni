using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CarRacing.Models.Maps
{
    public class Map : IMap
    {
        public string StartRace(IRacer racerOne, IRacer racerTwo)
        {
            if (racerOne.IsAvailable() == false)
            {
                return $"{racerTwo} wins the race! {racerOne} was not available to race!";
            }
            else if (racerTwo.IsAvailable() == false)
            {
                return $"{racerOne} wins the race! {racerTwo} was not available to race!";
            }  
            else if (racerTwo.IsAvailable() == false && racerOne.IsAvailable() == false)
            {
                return "Race cannot be completed because both racers are not available!";
            }

            racerOne.Race();
            racerTwo.Race();

            double resultOne = 0;
            double resultTwo = 0; 

            if(racerOne.RacingBehavior == "aggressive" )
            {
                 resultOne = (racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.1);
               
            }
            else if(racerOne.RacingBehavior == "strict")
            {
                resultOne = racerOne.Car.HorsePower * racerOne.DrivingExperience * 1.2;
            }

            if(racerTwo.RacingBehavior == "aggressive")
            {
                resultTwo = (racerTwo.Car.HorsePower * racerTwo.DrivingExperience) * 1.1;
            }
            else if (racerTwo.RacingBehavior == "strict")
            {
               resultTwo = (racerTwo.Car.HorsePower * racerTwo.DrivingExperience) * 1.2;
            }

            if(resultOne > resultTwo)
            {
                return $"{racerOne.Username} has just raced against " +
                    $"{racerTwo.Username}! {racerOne.Username} is the winner!";
            }
            else 
            {
                return $"{racerOne.Username} has just raced against " +
                    $"{racerTwo.Username}! {racerTwo.Username} is the winner!";
            }



        }
    }
}
