using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        { 
            double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray(); 
            SortedDictionary <double,int> count = new SortedDictionary<double, int> ();

            foreach (double i in arr)
            { 
                if (count.ContainsKey(i))
                {
                    count[i]++;
                }  
                else
                {
                    count.Add(i, 1);
                }
            }
            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
            

        }
    }
}   