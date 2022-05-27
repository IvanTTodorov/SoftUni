using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productsInfo = Console.ReadLine().Split();
            List<Products> productsList = new List<Products>();
            var dict = new Dictionary<string, Products>();
            while (productsInfo[0] != "buy")
            {
                string name = productsInfo[0];
                double price = double.Parse(productsInfo[1]);
                int quantity = int.Parse(productsInfo[2]);

                Products products = new Products(name, price, quantity);


                if (!dict.ContainsKey(name))
                {

                    dict.Add(name, products);
                }
                else
                {
                    dict[name].Price = price;
                    dict[name].Quantity += quantity;
                }
                productsInfo = Console.ReadLine().Split();
            }
            foreach (var pair in dict)
            {
                double price = pair.Value.Price * pair.Value.Quantity;
                Console.WriteLine($"{pair.Key} -> {price:f2}");

            }
        }
    }
    public class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }


}