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

            string input = string.Empty;
            double totalMoney = 0;

            Console.WriteLine("Bought furniture:");

            while ((input = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, @">>(?<name>[A-Za-z]+)<<(?<price>\d+\.?\d*)!(?<quantity>\d+)");
                
                foreach(Match match in matches)
                {
                    totalMoney += double.Parse(match.Groups["price"].Value) * double.Parse(match.Groups["quantity"].Value);
                    Console.WriteLine(match.Groups["name"].Value);
                }
            }
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}