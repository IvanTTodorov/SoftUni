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
            MatchCollection matches = Regex.Matches(Console.ReadLine()
          , @"(?<=\s)(?<user>[A-Za-z0-9]+[._-]*\w*)*@(?<host>[a-z]+[.-]*[a-z]*[.][a-z]{2,})");

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}