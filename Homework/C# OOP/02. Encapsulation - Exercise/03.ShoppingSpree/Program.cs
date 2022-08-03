using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                List<Person> allPeople = new List<Person>();
                List<Product> allProducts = new List<Product>();
                string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < people.Length; i++)
                {
                    string[] personInfo = people[i].Split("=");
                    Person person = new Person(personInfo[0], decimal.Parse(personInfo[1])); ;
                    allPeople.Add(person);
                }
                for (int i = 0; i < products.Length; i++)
                {
                    string[] productsInfo = products[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(productsInfo[0], int.Parse(productsInfo[1]));
                    allProducts.Add(product);
                }

                string input = string.Empty;
                while ((input = Console.ReadLine()) != "END")
                {

                    string[] purchase = input.Split();
                    string name = purchase[0];
                    string product = purchase[1];

                    Person currentPerson = allPeople.FirstOrDefault(x => x.Name == name);
                    Product currentProduct = allProducts.FirstOrDefault(x => x.Name == product);

                    currentPerson.AddProducts(currentProduct);
                }

                foreach (var person in allPeople)
                {
                    if (person.Products.Count == 0)
                    {
                        Console.WriteLine($"{person.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{person.Name} - {string.Join(", ", person.Products.Select(x => x.Name))}");
                    }
                }
            } 
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
} 
