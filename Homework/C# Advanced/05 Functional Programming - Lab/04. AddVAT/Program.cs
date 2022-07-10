using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        var elements = Console.ReadLine().Split(", ").Select(double.Parse).ToList(); 
        
        foreach (var element in elements)
        {
            double item = element; 
            item += element * 0.2;
            Console.WriteLine($"{item:f2}");
        }
       
    }
}