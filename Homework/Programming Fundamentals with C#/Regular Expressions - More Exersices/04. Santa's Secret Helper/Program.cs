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
            int key = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            while (input != "end")
            {
                string newText = String.Empty;
                for (int i = 0; i < input.Length; i++)
                {
                    newText += (char)(char.Parse(input[i].ToString()) - key);
                }

                Match match = Regex.Match(newText, @"@([A-Za-z]+)[^@\-!:>]*!([GN])!");
                string name = match.Groups[1].Value;
                string behavior = match.Groups[2].Value;
                
                if(behavior == "G")
                {
                    Console.WriteLine(name);
                }
                input = Console.ReadLine();
            }

       
        }
    }
} 
