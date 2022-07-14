using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Family family = new Family();
            int n = int.Parse(Console.ReadLine());
            List<Person> newPeople = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split(' ');
                string name = personInfo[0];
                int age = int.Parse(personInfo[1]);

                Person person = new Person(name, age);
                family.AddMember(person, family.People);

            }
            newPeople = family.OldestPeople(family.People); 
            foreach (var person in newPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}