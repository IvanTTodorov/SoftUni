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
            int n = int.Parse(Console.ReadLine());
            List<Match> attackedPlanets = new List<Match>();
            List<Match> destroyedPlanets = new List<Match>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string lowerCase = input.ToLower();
                int count = 0;
                string newText = String.Empty;
                for (int j = 0; j < lowerCase.Length; j++)
                {
                    if (lowerCase[j] == 115 || lowerCase[j] == 97 || lowerCase[j] == 114 || lowerCase[j] == 116)
                    {
                        count++;
                    }
                }
                for (int j = 0; j < input.Length; j++)
                {
                    newText += Convert.ToChar(input[j] - count);
                }

                MatchCollection matches = Regex.Matches(newText
                    , @"[^@-|:>]*@(?<name>[A-Za-z]+)[^@!:>\-]*:[^@-|:>]*?(?<population>\d+)[^@-|:>]*![^@-|:>]*(?<attack>[AD])!->(?<soldiers>\d+)[^@-|:>]*");

                foreach (Match match in matches)
                {
                    if (match.Groups["attack"].Value == "A")
                    {
                        attackedPlanets.Add(match);
                    }
                    else
                    {
                        destroyedPlanets.Add(match);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            if (attackedPlanets.Count > 0)
            {
                foreach (var item in attackedPlanets.OrderBy(x => x.Groups["name"].Value))
                {
                    Console.WriteLine($"-> {item.Groups["name"]}");
                }
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            if (destroyedPlanets.Count > 0)
            {
                foreach (var item in destroyedPlanets.OrderBy(x => x.Groups["name"].Value))
                {
                    Console.WriteLine($"-> {item.Groups["name"]}");
                }
            }
        }
    }
}