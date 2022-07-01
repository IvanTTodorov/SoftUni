using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string colour = input[0];

            string[] clothes = input[1].Split(",");

            if (!wardrobe.ContainsKey(colour))
            {
                wardrobe.Add(colour, new Dictionary<string, int>());
                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    wardrobe[colour].Add(clothes[cloth], 1);
                }
            }
            else
            {
                for (int cloth = 0; cloth < clothes.Length; cloth++)
                {
                    if (!wardrobe[colour].ContainsKey(clothes[cloth]))
                    {
                        wardrobe[colour].Add(clothes[cloth], 1);
                    }
                    else
                    {
                        wardrobe[colour][clothes[cloth]]++;
                    }
                }
            }
        }
        string[] command = Console.ReadLine().Split();

        foreach (var item in wardrobe)
        {
          
                Console.WriteLine($"{item.Key} clothes:");
            Dictionary<string, int> newClothes = item.Value; 

                foreach (var clothes in newClothes)
                {
                    if (command[1] == clothes.Key && command[0] == item.Key)
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothes.Key} - {clothes.Value}");
                    }
                }
            }

        }
    }
