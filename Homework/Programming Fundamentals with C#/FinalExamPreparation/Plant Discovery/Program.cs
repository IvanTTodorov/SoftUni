using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Flower> flowerInfo = new Dictionary<string, Flower>();

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split("<->");
                string name = text[0];
                int rarity = int.Parse(text[1]);

                if (!flowerInfo.ContainsKey(name))
                {
                    Flower flower = new Flower();
                    flower.Name = name;
                    flower.Rarity = rarity;
                    flower.Rating = new List<int>();
                    flowerInfo.Add(name, flower);
                }
                else
                {
                    flowerInfo[name].Rarity = rarity;
                }

            }
            string command = Console.ReadLine();

            while (command != "Exhibition")
            {
                Match match = Regex.Match(command, @"([A-Za-z]+): ([A-Za-z]+) ?-? ?(\d*)");
                string command1 = match.Groups[1].Value;
                string plant = match.Groups[2].Value;


                if (flowerInfo.ContainsKey(plant))
                {
                    if (command1 == "Rate")
                    {
                        int rating = int.Parse(match.Groups[3].Value);
                        flowerInfo[plant].Rating.Add(rating);
                    }
                    else if (command1 == "Update")
                    {
                        int rating = int.Parse(match.Groups[3].Value);
                        flowerInfo[plant].Rarity = rating;
                    }
                    else if (command1 == "Reset")
                    {
                        flowerInfo[plant].Rating.RemoveRange(0,flowerInfo[plant].Rating.Count);
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }



                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in flowerInfo)
            {
                if (item.Value.Rating.Sum() == 0)
                {
                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: 0.00");
                }
                else
                {

                    Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.Rating.Average():f2}");
                }
            }
        }
    }
    public class Flower
    {
        public string Name { get; set; }
        public int Rarity { get; set; }
        public List<int> Rating { get; set; }

    }
}