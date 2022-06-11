using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = string.Empty;
        Dictionary<string, double> product = new Dictionary<string, double>();
        Dictionary<string, Dictionary<string, double>> store = new Dictionary<string, Dictionary<string, double>>();

        while ((text = Console.ReadLine()) != "Revision")
        {
            string[] information = text.Split(", ");
            string storeName = information[0];
            string productName = information[1];
            double price = double.Parse(information[2]);
            product.Add(productName, price);

            if (!store.ContainsKey(storeName))
            {
                store.Add(storeName, new Dictionary<string, double>());

                if (!store[storeName].ContainsKey(productName))
                {
                    store[storeName].Add(productName, price);
                }
                else
                {
                    store[storeName] = (product);
                }
            }
            else
            {
                if (!store[storeName].ContainsKey(productName))
                {
                    store[storeName].Add(productName, price);
                }
                else
                {
                    store[storeName] = (product);
                }
            } 
            

            product.Remove(productName);
        }

        
        foreach (var item in store.OrderBy(x=>x.Key))
        {
            
            Console.WriteLine($"{item.Key}->");
            foreach (var productAndPrice in item.Value)
            {
                Console.WriteLine($"Product: {productAndPrice.Key}, Price: {productAndPrice.Value}");
            }
        }

    }
}