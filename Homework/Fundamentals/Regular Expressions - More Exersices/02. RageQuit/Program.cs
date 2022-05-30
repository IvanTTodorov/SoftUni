using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"([\D]+)([\d]+)");
            StringBuilder uniqueSymbols = new StringBuilder(); 
            string symbols = String.Empty;
            int symbolsCount = 0;

            foreach (Match match in matches)
            {
                string letters = match.Groups[1].Value;
                int digit = int.Parse(match.Groups[2].Value);

                for (int i = 0; i < digit; i++)
                {
                    uniqueSymbols.Append(letters);
                }
            }
            string symbolsUpperCases = uniqueSymbols.ToString().ToUpper(); 
            symbolsCount = symbolsUpperCases.Distinct().Count();    
            
            Console.WriteLine($"Unique symbols used: {symbolsCount}");
            Console.WriteLine(symbolsUpperCases);
        }
    }
}