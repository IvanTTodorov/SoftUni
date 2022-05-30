using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 } ;
            
             foreach (int num in arr)
            {
                Console.WriteLine($"{num}"); 
            }

        }
    }
}