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
        int count = 0;
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        int value = 0;
        int diff = 0;

        for (int i = 0; i <= n - 1; i++)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            dict.Add(i, new List<int>());
            dict[i].Add(numbers[0]);
            dict[i].Add(numbers[1]);

        }
        while (true)
            foreach (var items in dict)
            {
                diff += items.Value[0];
                diff -= items.Value[1];
                 
                if (diff >= 0)
                {
                    count++;
                    if (count == 1)
                    {
                        value = items.Key;

                    }
                    if (count > n)
                    {
                        Console.WriteLine(value);
                        return;
                    }
                }
                else
                {
                    diff = 0;
                    count = 0;
                }
            }
    }
}


