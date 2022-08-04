using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizzaInfo = Console.ReadLine().Split();
                string[] doughInfo = Console.ReadLine().Split();
                
                Dough dough = new Dough(doughInfo[1], doughInfo[2], int.Parse(doughInfo[3]));
                Pizza pizza = new Pizza(pizzaInfo[1], dough);

                string[] toppingInfo = Console.ReadLine().Split();
                while (toppingInfo[0] != "END")
                {
                    
                    Topping topping = new Topping(toppingInfo[1], int.Parse(toppingInfo[2]));
                    pizza.AddToppings(topping);
                    toppingInfo = Console.ReadLine().Split();
                }

                Console.WriteLine($"{pizza.PizzaName} - {pizza.TotalCalories:f2} Calories.");
             
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
           }
        }
    }
} 

