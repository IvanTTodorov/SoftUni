using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace Tuple
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] nameTownInput = Console.ReadLine().Split();
            string firstName = nameTownInput[0];
            string secondName = nameTownInput[1];
            string town = nameTownInput[2]; 

            string[] nameAndBeer = Console.ReadLine().Split();
            string name = nameAndBeer[0];
            int amountOfBeer = int.Parse(nameAndBeer[1]);

            string[] thirdArr = Console.ReadLine().Split();
            int integer = int.Parse(thirdArr[0]);
            double db = double.Parse(thirdArr[1]);


            MyTuple<string, string> NameAndTown = new MyTuple<string, string>
                ($"{firstName} {secondName}", town);


            MyTuple<string, int> NameAndBeer = new MyTuple<string, int>
                (name,amountOfBeer);

            MyTuple<int, double> IntegerAndDouble = new MyTuple<int, double>
                (integer,db);

            Console.WriteLine(NameAndTown.GetItems());
            Console.WriteLine(NameAndBeer.GetItems());
            Console.WriteLine(IntegerAndDouble.GetItems()); 

        }
    }
}