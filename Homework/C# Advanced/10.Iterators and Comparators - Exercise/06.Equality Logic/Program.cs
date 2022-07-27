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
            int n = int.Parse(Console.ReadLine());
            SortedSet<Person> sortedSet = new SortedSet<Person>();
            HashSet<Person> hashSet = new HashSet<Person>(); 

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();
                string name = personInfo[0].ToLower();
                int age = int.Parse(personInfo[1]);
                Person person = new Person(name,age);
                sortedSet.Add(person);
                hashSet.Add(person);
            }
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);
        }
    }
} 