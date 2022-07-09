using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int[] elements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int count = elements.Count();
        int sum = elements.Sum();
        Console.WriteLine(count);
        Console.WriteLine(sum);
    }
}