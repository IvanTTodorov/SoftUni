using System;

namespace Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            SandwichMenu sandwichMenu = new SandwichMenu();

            sandwichMenu["BLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato");
            sandwichMenu["PB&J"] = new Sandwich("White", "", "", "Peanut Butter, Jelly");
            sandwichMenu["Turkey"] = 
                new Sandwich("Rye", "Turkey", "Swiss", "Lettuce, Onion, Tomato");



            sandwichMenu["LoadedBLT"] = new Sandwich("Wheat", "Bacon", "", "Lettuce, Tomato, Onion, Olives");


            Sandwich sandwich1 = sandwichMenu["BLT"].Clone() as Sandwich;
            Sandwich sandwich2 = sandwichMenu["Turkey"].Clone() as Sandwich;

        }
    }
}
