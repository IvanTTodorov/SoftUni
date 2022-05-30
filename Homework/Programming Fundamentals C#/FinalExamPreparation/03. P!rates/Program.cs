using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("||");
            Dictionary<string, Towns> addedTowns = new Dictionary<string, Towns>();
            while (input[0] != "Sail")
            {
                string townName = input[0];
                int population = int.Parse(input[1]);
                int gold = int.Parse(input[2]);

                if (addedTowns.ContainsKey(townName))
                {
                    addedTowns[townName].Gold += gold;
                    addedTowns[townName].Population += population;
                } 
                else
                {
                    Towns towns = new Towns();
                    towns.TownName = townName;
                    towns.Population = population;
                    towns.Gold = gold;
                    addedTowns.Add(townName, towns);
                }
                input = Console.ReadLine().Split("||");
            }

            string[] events = Console.ReadLine().Split("=>"); 
            while (events[0] != "End")
            {
               
                if(events[0] == "Plunder")
                {
                    Plunder(addedTowns, events);
                } else if (events[0] == "Prosper")
                {
                    Prosper(addedTowns, events);
                }
                events = Console.ReadLine().Split("=>");
            }
            if(addedTowns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {addedTowns.Count} wealthy settlements to go to:");
               foreach(var item in addedTowns)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
        public static void Plunder (Dictionary<string, Towns> addedTowns, string[] events)
        {
            string town = events[1];
            int people = int.Parse(events[2]);
            int gold = int.Parse(events[3]);

            addedTowns[town].Population -= people;
            addedTowns[town].Gold -= gold;
            Console.WriteLine($"{town} plundered! {gold} gold stolen, {people} citizens killed.");

            if (addedTowns[town].Population <= 0 || addedTowns[town].Gold <= 0)
            {
                addedTowns.Remove(town);
                Console.WriteLine($"{town} has been wiped off the map!");
            }

        }
        public static void Prosper (Dictionary<string, Towns> addedTowns, string[] events)
        {
            string town = events[1];
            int gold = int.Parse(events[2]); 

            if(gold < 0)
            {
                Console.WriteLine($"Gold added cannot be a negative number!");
            }
            else
            {
                 addedTowns[town].Gold += gold;
                Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {addedTowns[town].Gold} gold.");
            }
        }
    }

        public class Towns
        {
            public string TownName { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
        }
    }



