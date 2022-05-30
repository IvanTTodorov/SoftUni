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
            List <string> input = Regex.Split(Console.ReadLine(), @" *,{1} *").ToList ();

            for (int i = 0; i < input.Count; i++)
            {
                string ticket = input[i];

                if (ticket.Length == 20)
                {
                    string leftHalf = ticket.Substring(0, 10);
                    string rightHalf = ticket.Substring(10);

                    MatchCollection leftMatches = Regex.Matches(leftHalf, @"@{6,}|#{6,}|\${6,}|\^{6,}");
                    MatchCollection rightMatches = Regex.Matches(rightHalf, @"@{6,}|#{6,}|\${6,}|\^{6,}");
                     
                    if (leftMatches.Count + rightMatches.Count < 2)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                    foreach (var item in leftMatches)
                    {
                        string leftSymbols = item.ToString();
                        foreach (var item1 in rightMatches)
                        {
                            string rightSymbols = item1.ToString();
                            if (leftSymbols.Length > rightSymbols.Length)
                            {
                                leftSymbols = rightSymbols.Substring(0, rightSymbols.Length);
                            } 
                            else if (leftSymbols.Length < rightSymbols.Length)
                            {
                                rightSymbols = leftSymbols.Substring(0, leftSymbols.Length);
                            }
                                if (leftSymbols == rightSymbols)
                                {

                                    if (leftSymbols.Length == 10)
                                    {
                                        Console.WriteLine($"ticket \"{ticket}\" - { leftSymbols.Length}{leftSymbols[0]} Jackpot!");
                                    }
                                    else
                                    {
                                        Console.WriteLine($"ticket \"{ticket}\" - { leftSymbols.Length}{leftSymbols[0]}");
                                    }
                                }
                            }
                        }
                    }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}
