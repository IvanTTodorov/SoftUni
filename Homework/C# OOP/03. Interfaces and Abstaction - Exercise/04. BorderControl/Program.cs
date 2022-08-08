using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
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

                if (arrInput.Length == 3)
                {
                    int age = int.Parse(arrInput[1]);
                    string id = arrInput[2];
                    identifiable = new Citizens(action, age, id);
                }
                else if (arrInput.Length == 2)
                {
                    string id = arrInput[1];
                    identifiable = new Robots(action, id);
                }
                allIdentifiables.Add(identifiable);
            }
            string lastDigits = Console.ReadLine();

            allIdentifiables.Where(c => c.Id.EndsWith(lastDigits))
           .Select(c => c.Id)
           .ToList()
           .ForEach(Console.WriteLine);
        }
    }
} 

