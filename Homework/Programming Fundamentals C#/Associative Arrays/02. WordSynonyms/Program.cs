using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            var dict = new Dictionary<string, List <string> >();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();  
                 
                if (dict.ContainsKey(word))
                {
                    dict[word].Add(synonym);
                }  
                else
                {
                    dict.Add(word, new List<string>());
                    dict[word].Add(synonym);
                }
            }
            foreach (var pair in dict)
            {
                Console.WriteLine( pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }
    }
}