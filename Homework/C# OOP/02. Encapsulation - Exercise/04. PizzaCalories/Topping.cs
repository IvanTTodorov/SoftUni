using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Topping
    {
        private Dictionary<string, double> allToppings = new Dictionary<string, double>()
        {
            {"meat", 1.2},
            {"veggies", 0.8},
            {"cheese", 1.1},
            {"sauce", 0.9}
        };
        private string currentTopping;
        private int weight;

        public string CurrentTopping
        {
            get { return currentTopping; }
            private set
            {
                if (!allToppings.ContainsKey(value.ToLower()))
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }
                currentTopping = value;
            }
        }
        public int Weight
        {
            get { return weight; }
           private set  
            {  
                if(value < 1 || value > 50)
                {
                    throw new ArgumentException($"{CurrentTopping} weight should be in the range [1..50].");
                }
                weight = value; }
        }
       
        public double Calculator => 2 * weight * allToppings[CurrentTopping.ToLower()];


        public Topping(string typesOfTopping, int weight)
        {
            CurrentTopping = typesOfTopping;
            Weight = weight;
            
        }   

    }
}
