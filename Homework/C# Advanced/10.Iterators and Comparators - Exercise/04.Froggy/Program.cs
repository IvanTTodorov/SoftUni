using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Lake lake = new Lake(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Console.WriteLine(String.Join(", ", lake));
        }
    }
}