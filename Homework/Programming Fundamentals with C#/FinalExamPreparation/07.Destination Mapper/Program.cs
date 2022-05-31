using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"([=|\/])([A-Z]+[A-Za-z]{2,})(\1)");
            int points = 0; 
            List<string> destinations = new List<string>();
            foreach (Match match in matches)
            {
                string name = match.Groups[2].Value;
                destinations.Add(name);
                points += name.Length;
            }
            Console.WriteLine($"Destinations: {string.Join(", ", destinations)}");
            Console.WriteLine($"Travel Points: {points}");

        }
    }
}