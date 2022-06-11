using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        double[] arr = Console.ReadLine().Split().Select(double.Parse).ToArray();
        Dictionary<double, int> dict = new Dictionary<double, int>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (!dict.ContainsKey(arr[i]))
            {
                dict.Add(arr[i], 1);
            }
            else
            {
                dict[arr[i]] += 1;
            }
        }

        foreach (var item in dict)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }

    }
}