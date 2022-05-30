using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
        int maxCapacity = int.Parse(Console.ReadLine());
        AddPeopleInWagons(wagons, maxCapacity);
    }



    static void AddPeopleInWagons(List<int> wagons, int maxCapacity)
    {
        string input;
        while ((input = Console.ReadLine()) != "end")
        {
            string[] text = input.Split();

            if (text[0] == "Add")
            {
                wagons.Insert(wagons.Count, int.Parse(text[1]));
            }
            else
            {
                for (int i = 0; i < wagons.Count; i++)
                {
                    if (int.Parse(input) + wagons[i] <= maxCapacity)
                    {
                        wagons[i] = wagons[i] + int.Parse(input);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                 
            }
        }
        Console.WriteLine(String.Join(" ", wagons));
    }
}