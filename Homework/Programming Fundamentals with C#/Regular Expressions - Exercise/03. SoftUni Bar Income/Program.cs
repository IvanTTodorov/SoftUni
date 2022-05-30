using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double total = 0; 

            while(input != "end of shift")
            {
                MatchCollection matches = Regex.Matches(input
                    , @"\%(?<customer>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$");
                
                foreach (Match match in matches)
                {
                    double totalPrice = double.Parse(match.Groups["count"].Value) * double.Parse(match.Groups["price"].Value);
                    var name = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value; 
                    Console.WriteLine($"{name}: {product} - {totalPrice:f2}");
                    total += totalPrice; 
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}