using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string first = inputs[0];
            string second = inputs[1];
            string longest = " ";
            string shortest = " ";

            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                shortest = first;
                longest = second;
            }

            int total = 0;
            for (int i = 0; i < shortest.Length; i++)
            {
                total += shortest[i] * longest[i];
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                total += longest[i];
            }

            Console.WriteLine(total);
        }
    }
}
