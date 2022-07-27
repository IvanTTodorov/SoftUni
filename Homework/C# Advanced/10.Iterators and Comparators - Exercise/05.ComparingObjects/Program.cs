using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] person = input.Split();
                people.Add(new Person(person[0], int.Parse(person[1]), person[2]));
            }

            int n = int.Parse(Console.ReadLine());
            int equal = 0;
            int notEqual = 0;
            
            foreach (var person in people)
            {
                if(people[n - 1].CompareTo(person) == 0)
                {
                    equal++; 
                } 
                else
                {
                    notEqual++;
                }
            } 
             
            if (equal <= 1)
            {
                Console.WriteLine($"No matches");
            }   
            else
            {
                Console.WriteLine($"{equal} {notEqual} {people.Count}");
            }
        }
    }
}