using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OldestFamilyMember
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();
            
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person member = new Person(name, age); 
                family.AddMember(member);
            }
         Person oldestMember = family.ReturnMethod();
            Console.WriteLine($"{oldestMember.NameOfThePerson} {oldestMember.AgeOfThePerson}"); 

        }
    }
    public class Person
    {
        public string NameOfThePerson { get; set; }
        public int AgeOfThePerson { get; set; }

        public Person(string name, int age)
        {
            NameOfThePerson = name;
            AgeOfThePerson = age; 
        }
    }
    public class Family
    {
        public List<Person> people = new List<Person>();
        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public Person ReturnMethod()
        {
            return people.OrderByDescending(x => x.AgeOfThePerson).FirstOrDefault();
           
        }

    }
}