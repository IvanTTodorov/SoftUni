using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine(); 
        Dictionary<char, int> newDict = new Dictionary<char, int>();

        for(int i = 0; i < text.Length; i++)
        {
            if (!newDict.ContainsKey(text[i]))
            {
                newDict.Add(text[i], 1);
            }
            else
            {
                newDict[text[i]]++;
            }
        }
        foreach (var item in newDict.OrderBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key}: {item.Value} time/s");
        }
    }
}