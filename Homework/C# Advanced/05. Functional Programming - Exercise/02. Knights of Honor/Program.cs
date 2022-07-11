using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> names = Console.ReadLine().Split().ToList();
        Action<List<string>> printNames = x =>x.ForEach(x => Console.WriteLine($"Sir {x}"));
        printNames(names);
    }
}