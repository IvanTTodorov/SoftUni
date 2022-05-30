using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine(); 
            List <DataOfThePerson> newData = new List <DataOfThePerson> ();
            while (input != "End")
            {
                string[] command = input.Split();
                string name = command[0];
                string id = command[1]; 
                int age = int.Parse(command[2]);

                if (newData.Any(x => x.ID == id))
                {
                    int index = newData.FindIndex(x => x.ID == id);
                    newData[index].Name = name;
                    newData[index].Age = age;

                }
                else
                {

                    DataOfThePerson data = new DataOfThePerson();
                    data.Name = name;
                    data.ID = id;
                    data.Age = age;

                    newData.Add(data);
                }

                input = Console.ReadLine();

            }
           List <DataOfThePerson> printList = newData.OrderBy(x => x.Age).ToList(); 
            Console.WriteLine(String.Join(Environment.NewLine, printList)); 

        }
    }
    public class DataOfThePerson
    {
        public string Name { get; set; }
        public  string ID { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }

    }
}