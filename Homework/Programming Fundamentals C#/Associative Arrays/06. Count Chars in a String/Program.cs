using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string elements = Console.ReadLine();

            var dict = new Dictionary<char, int>();


            for (int i = 0; i < elements.Length; i++)
            {
                char symbol = elements[i];
                if (elements[i] == ' ')
                {
                    continue;
                }

                if (dict.ContainsKey(symbol))
                {
                    dict[symbol]++;
                }
                else
                {
                    dict.Add(symbol, 1);
                }
            }
            dict.OrderByDescending(x => x); 
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
