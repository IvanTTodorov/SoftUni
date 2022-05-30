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
            List<string> names = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> information = new Dictionary<string, int>();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of race")
            {
                var namematched = Regex.Matches(input, @"[A-Za-z]");
                var digits = Regex.Matches(input, @"\d");

                string newname = String.Concat(namematched);
                int result = digits.Sum(x => int.Parse(x.Value));


                AddInfoInDict(names, newname, information, result);
            }

            var sorted = information.OrderByDescending(x => x.Value).Select(x=>x.Key).ToList();
            Console.WriteLine("1st place: " + sorted[0]);
            Console.WriteLine("2nd place: " + sorted[1]);
            Console.WriteLine("3rd place: " + sorted[2]);
        }
        public static void AddInfoInDict(List<string> names, string newname, Dictionary<string, int> information, int result)
        {
            if (names.Contains(newname))
            {
                if (!information.ContainsKey(newname))
                {
                    information.Add(newname, result);
                }
                else
                {
                    information[newname] += result;
                }
            }
        }
    }
}
