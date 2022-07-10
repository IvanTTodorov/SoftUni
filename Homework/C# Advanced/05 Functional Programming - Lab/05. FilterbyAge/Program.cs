using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<People> peopleInfo = new List<People>();

        for (int i = 0; i < n; i++)
        {
            string[] person = Console.ReadLine().Split(", ");
            string name = person[0];
            int age = int.Parse(person[1]);

            People onePerson = new People();
            onePerson.Name = name;
            onePerson.Age = age;
            peopleInfo.Add(onePerson);
        }
        string filterName = Console.ReadLine();
        int number = int.Parse(Console.ReadLine());


        Func<People, bool> filter = p => true;
        if (filterName == "younger")
        {
            filter = x => x.Age < number;
        }
        else if (filterName == "older")
        {
            filter = x => x.Age >= number;
        }
        var filteredPeople = peopleInfo.Where(filter);

        var print = Console.ReadLine();
        Func<People, string> secondFunction = x => x.Name + " " + x.Age;

        if (print == "name age")
        {
            secondFunction = x => x.Name + " - " + x.Age;
        }
        else if (print == "name")
        {
            secondFunction = x => x.Name;
        }
        else if (print == "age")
        {
            secondFunction = x => x.Age.ToString();
        }

        var output = filteredPeople.Select(secondFunction); 
        foreach (var person in output)
        {
            Console.WriteLine(person);
        }
    }
}

public class People
{
    public string Name { get; set; }
    public int Age { get; set; }
}