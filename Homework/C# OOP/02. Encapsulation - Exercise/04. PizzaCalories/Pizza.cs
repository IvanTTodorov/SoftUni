using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class Pizza
    {
        private double allTopingsCalories;
        private string pizzaName;
        private List<Topping> allToppings; 

        public string PizzaName
        {
            get
            {
                return pizzaName;
            }
            private set
            {
                if (value.Length < 1 || value.Length > 15)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }
                pizzaName = value;
            }
        }
        public Dough Dough { get; private set; }

        public Pizza(string pizzaName, Dough dough)
        {
            PizzaName = pizzaName;
            allToppings = new List<Topping>();
            Dough = dough;
        }

        public void AddToppings(Topping topping)
        {
            if (allToppings.Count < 0 || allToppings.Count > 10)
            {
                throw new InvalidOperationException("Number of toppings should be in range [0..10].");
            }
            allToppings.Add(topping);
        }
        public double TotalCalories => Dough.Calculator + allToppings.Sum(x => x.Calculator);
    }
}
