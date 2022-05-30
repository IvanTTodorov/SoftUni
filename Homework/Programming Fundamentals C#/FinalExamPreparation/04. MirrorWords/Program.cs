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
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"(@|#)([A-Za-z]{3,})(\1)(\1)([A-Za-z]{3,})(\1)");
            List <string> output = new List<string>();  

            foreach (Match match in matches)
            {
                string firstWord = match.Groups[2].Value; 
                string secondWord = match.Groups[5].Value;

                char[] newWord = secondWord.ToCharArray();
                Array.Reverse(newWord);
                string reversedWord = new string(newWord); 
 
                if(firstWord == reversedWord)
                {
                    output.Add($"{firstWord} <=> {secondWord}");
                }
             }
            if(matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");
            }
            else if(matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            if(output.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else if(output.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                    Console.Write(string.Join(", ",output));
            }
        }
    }
}