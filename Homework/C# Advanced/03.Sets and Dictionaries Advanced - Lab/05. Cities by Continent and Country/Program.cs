using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, Dictionary<string, List<string>>> continent = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            List<string> input = Console.ReadLine().Split().ToList();
            string continentName = input[0];
            string countryName = input[1];
            string cityName = input[2];

            if (!continent.ContainsKey(continentName))
            {
                continent.Add(continentName, new Dictionary<string, List<string>>());
                continent[continentName].Add(countryName, new List<string>());
                continent[continentName][countryName].Add(cityName);
            }
            else
            {
                if (!continent[continentName].ContainsKey(countryName))
                {
                    continent[continentName].Add(countryName, new List<string>());
                    continent[continentName][countryName].Add(cityName);
                }
                else
                {
                    if (!continent[continentName][countryName].Contains(cityName))
                    {
                        continent[continentName][countryName].Add(cityName);
                    }
                }
            }
        }
        foreach (var item in continent)
        {
            Console.WriteLine($"{item.Key}:");
            foreach (var country in item.Value)
            {
                Console.WriteLine($"{country.Key} -> {String.Join(", ", country.Value)}");
            }

        }
    }
}
