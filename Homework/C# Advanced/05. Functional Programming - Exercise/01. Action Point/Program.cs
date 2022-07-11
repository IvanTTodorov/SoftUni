using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split();
        Action<string[]> printNames = names => Console.WriteLine(String.Join(Environment.NewLine, names));
        printNames(names);  
    }
}