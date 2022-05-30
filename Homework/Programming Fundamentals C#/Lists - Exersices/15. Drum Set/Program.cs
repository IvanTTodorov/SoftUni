using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        double budget = double.Parse(Console.ReadLine());
        List<int> drumSet = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input = Console.ReadLine();
        List<int> initialQuality = new List<int>(drumSet);

        while (input != "Hit it again, Gabsy!")
        {
            int hitPower = int.Parse(input);
            for (int i = 0; i < drumSet.Count; i++)
            {
                if (drumSet[i] - hitPower <= 0)
                {
                    if (budget >= initialQuality[i] * 3)
                    {
                        drumSet[i] = initialQuality[i];
                        budget = budget - initialQuality[i] * 3;
                    } else
                    {
                        drumSet.RemoveAt(i); 
                        initialQuality.RemoveAt(i);
                        i = i - 1;
                    }
                }
                else
                {
                    drumSet[i] = drumSet[i] - hitPower;
                }
            }
            input = Console.ReadLine();
        }
        Console.WriteLine(String.Join(" ", drumSet));
        Console.WriteLine($"Gabsy has {budget:f2}lv.");
    }

}