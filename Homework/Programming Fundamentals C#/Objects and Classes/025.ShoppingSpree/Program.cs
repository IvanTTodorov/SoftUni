using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] people = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(new char[] { ';', '=' }, StringSplitOptions.RemoveEmptyEntries);

            List<Person> currentPerson = new List<Person>();
            List<Products> currentProducts = new List<Products>();

            for (int i = 0; i < people.Length; i += 2)
            {
                string name = people[i];
                decimal money = decimal.Parse(people[i + 1]);

                Person person = new Person(name, money);
                currentPerson.Add(person);
            }
            for (int i = 0; i < products.Length; i += 2)
            {
                string name = products[i];
                decimal price = decimal.Parse(products[i + 1]);

                Products product = new Products(name, price);
                currentProducts.Add(product);
            }



            string[] command = Console.ReadLine().Split();
            while (command[0] != "END")
            {
                Products product = currentProducts.Find(x => x.Name == command[1]);

                currentPerson.Find(x => x.Name == command[0]).Shopping(product);

                command = Console.ReadLine().Split();
            }

            List<Person> peopleWithBags = currentPerson.Where(x => x.bagOfProducts.Count > 0).ToList(); 
            List<Person> peopleWithoutBags = currentPerson.Where(x=> x.bagOfProducts.Count == 0).ToList();

            foreach (var person in peopleWithBags)
            {
                Console.WriteLine(String.Join(Environment.NewLine, person));
            } 
            foreach (var person in peopleWithoutBags) 

            {
                string name = person.Name;
                Console.WriteLine($"{name} - Nothing bought");

            }
        }

        public class Person
        {
            public string Name { get; set; }
            public decimal Money { get; set; }

            public List<string> bagOfProducts = new List<string>();

            public Person(string name, decimal money)
            {
                Name = name;
                Money = money;
            }

            public void Shopping(Products product)
            {
                string name = product.Name;
                decimal price = product.Cost;
                if (Money >= price)
                {

                    Console.WriteLine($"{Name} bought {name}");
                    Money -= price;
                    bagOfProducts.Add(name);
                }
                else
                {
                    Console.WriteLine($"{Name} can't afford {name}");
                }
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(Name + " " + "-" + " ");
                foreach (var product in bagOfProducts)
                {
                    sb.Append(product + "," + " ");
                    
                }
                StringBuilder result = sb.Remove(sb.Length - 2, 2);
                return result.ToString().TrimEnd();
            }

        }

        public class Products
        {
            public string Name { get; set; }
            public decimal Cost { get; set; }

            public Products(string name, decimal cost)
            {
                Name = name;
                Cost = cost;
            }
        }


    }
}