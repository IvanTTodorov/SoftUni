using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(n => n).Take(3).ToList();

            Console.WriteLine(String.Join(" ", n));

        }
    }
}