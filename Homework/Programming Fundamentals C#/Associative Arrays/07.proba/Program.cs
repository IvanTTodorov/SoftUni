using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var dict = new Dictionary<string, int>();
           
            while (true)
            {
                string text = Console.ReadLine(); 
                if (text == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(text))
                {
                    dict.Add(text, quantity);
                }
                else
                {
                    dict[text] += quantity;
                }
             }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
            
        }
    }
}