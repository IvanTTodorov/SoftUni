using BirthdayCelebrations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebration
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> allIdentifiables = new List<IIdentifiable>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                IIdentifiable identifiable = null;
                string[] arrInput = input.Split();
                string action = arrInput[0];
                string name = arrInput[1];


                if (arrInput.Length == 5)
                {
                    int age = int.Parse(arrInput[2]);
                    string id = arrInput[3];
                    string birthDate = arrInput[4];
                    identifiable = new Citizens(name,age,id,birthDate);
                    allIdentifiables.Add(identifiable);
                }
                else if (action == "Pet")
                {
                    string birthDate = arrInput[2];
                    identifiable = new Pet(name, birthDate);
                    allIdentifiables.Add(identifiable);
                }
                
            }
            string lastDigits = Console.ReadLine();

            allIdentifiables.Where(c => c.Birthdate.EndsWith(lastDigits))
           .Select(c => c.Birthdate)
           .ToList()
           .ForEach(Console.WriteLine);
        }
    }
}

