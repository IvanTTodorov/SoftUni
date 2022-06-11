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
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();
       
        for (int i = 0; i < n; i++)
        {
           string[] input = Console.ReadLine().Split();
            string name = input[0];
            decimal mark = decimal.Parse(input[1]); 

            if(!students.ContainsKey(name))
            {
                students.Add(name, new List<decimal>());
                students[name].Add(mark);
            }
            else
            {
                students[name].Add(mark);
            }
        }
        foreach (var item in students)
        {
            StringBuilder allgrades = new StringBuilder();
            for (int i = 0; i < item.Value.Count; i++)
            {
                allgrades.Append($"{item.Value[i]:f2} ");
            }
            Console.WriteLine($"{ item.Key} -> {allgrades.ToString()}(avg: {item.Value.Average():f2})");
        }
    }
}