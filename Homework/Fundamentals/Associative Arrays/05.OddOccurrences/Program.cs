using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();
            Dictionary<string, int> input = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string newWord = word.ToLower();

                if (input.ContainsKey(newWord))
                {
                    input[newWord]++;
                }
                else
                {
                    input.Add(newWord, 1);
                }
            }

            foreach (var text in input)
            {
                if (text.Value % 2 == 1)
                {
                    Console.Write(text.Key + " ");
                }
            }
        }
    }
}

