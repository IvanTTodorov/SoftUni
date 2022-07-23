using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Threeuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string[] firstInput = Console.ReadLine().Split();
            string firstName = $"{firstInput[0]} {firstInput[1]}";
            string adress = firstInput[2];
            string town = String.Join(" ", firstInput.Skip(3));
            

            string[] secondInput = Console.ReadLine().Split();
            string name = secondInput[0];
            int amountOfBeer = int.Parse(secondInput[1]);
            string drunkOrNot = secondInput[2];
            bool drunkBeer = true;
            if (drunkOrNot == "drunk")
            {
                drunkBeer = true;
            }
            else
            {
                drunkBeer = false;
            }


            string[] thirdInput = Console.ReadLine().Split();
            string nameAccount = thirdInput[0];
            double amount = double.Parse(thirdInput[1]);
            string bankName = thirdInput[2];


                Threeuple<string, string, string> NameAndTown = new Threeuple<string, string, string>
                       (firstName,  adress, town);
                Console.WriteLine(NameAndTown.GetItems());

            Threeuple<string, int, bool> NameAndBeer = new Threeuple<string, int, bool>
                (name, amountOfBeer, drunkBeer);

            Threeuple<string, double, string> NameAndBankAccount = new Threeuple<string, double, string>
                (nameAccount, amount, bankName);

            Console.WriteLine(NameAndBeer.GetItems());
            Console.WriteLine(NameAndBankAccount.GetItems());

        }
    }
}