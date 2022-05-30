using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder digits = new StringBuilder(); 
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                } 
                else if (char.IsLetter(text[i]))
                {
                    letters.Append(text[i]);    
                } 
                else
                {
                    characters.Append(text[i]);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}