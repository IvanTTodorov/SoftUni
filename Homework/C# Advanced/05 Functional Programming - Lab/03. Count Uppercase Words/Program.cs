using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

        Func<string,bool> predicate = (word => char.IsUpper(word[0]));
        List<string> words = input.Where(predicate).ToList();
        foreach (var word in words)
        {
            Console.WriteLine(word);
        }
    }
}