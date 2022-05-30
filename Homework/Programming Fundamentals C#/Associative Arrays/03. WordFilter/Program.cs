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
            string [] words = Console.ReadLine().Split();
            words = words.Where(words => words.Length % 2 == 0).ToArray();
            Console.WriteLine(String.Join(Environment.NewLine, words));
        }
    }
}