using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();  

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                Person person = new Person(personInfo[0], personInfo[1], int.Parse(personInfo[2]));
                people.Add(person);
            } 
              
            people.OrderBy(x=>x.FirstName) 
                .ThenBy(x=>x.Age) 
                .ToList()
                .ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}