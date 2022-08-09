using FoodStortage;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodShortage
{
    public class Citizens : IIdentifiable
    {
        public Citizens(string name, string age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
            Food = 0;
        }

        public string Name { get; set; }
        public string  Age { get; set; }
        public string Id { get; set; }
        public string Birthdate { get; set; }
        public int Food { get; set; } 
        

        public int BuyFood()
        {
            Food += 10;
            return Food;
        }

    }
}
