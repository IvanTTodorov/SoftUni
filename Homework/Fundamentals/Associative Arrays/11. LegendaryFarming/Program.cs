using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var dict = new Dictionary<string, int>();
            var junkDict = new Dictionary<string, int>();
            dict.Add("shards", 0);
            dict.Add("motes", 0);
            dict.Add("fragments", 0);

            while (true)
            {
                string[] arr = Console.ReadLine().Split();
                for (int i = 0; i < arr.Length; i += 2)
                {
                    int quantity = 0;
                    quantity = int.Parse(arr[i]);
                    Legendary(dict, junkDict, quantity, arr, i);
                }
            }
            
        }
        static void Legendary(Dictionary<string, int> dict, Dictionary<string, int> junkDict,
            int quantity, string[] arr, int i)
        {
            foreach (var pair in dict)
            {
                if (pair.Value >= 250)
                {
                    if (pair.Key == "motes")
                    {
                        Console.WriteLine($"Dragonwrath obtained");
                    } 
                    else if (pair.Key == "fragments")  
                    {
                        Console.WriteLine($"Valanyr obtained");
                    }
                    else if (pair.Key == "shards")
                    {
                        Console.WriteLine($"Shadowmourne  obtained");
                    }
                    dict[pair.Key] -= 250;
                     
                    foreach (var item in dict)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }
                    foreach (var itemJunk in junkDict)
                    {
                        Console.WriteLine($"{itemJunk.Key}: {itemJunk.Value}");
                    }
                }
            }

            if (arr[i + 1].ToLower() == "shards")
            {

                if (!dict.ContainsKey("shards"))
                {
                    dict.Add("shards", quantity);
                }
                else
                {
                    dict["shards"] += quantity;
                }


            }
            else if (arr[i + 1].ToLower() == "fragments")
            {
                
                if (!dict.ContainsKey("fragments"))
                {
                    dict.Add("fragments", quantity);
                }
                else
                {
                    dict["fragments"] += quantity;
                }
            }
            else if (arr[i + 1].ToLower() == "motes")
            {
                
                if (!dict.ContainsKey("motes"))
                {
                    dict.Add("motes", quantity);
                }
                else
                {
                    dict["motes"] += quantity;
                }
            }
            else
            {
                if (!junkDict.ContainsKey(arr[i + 1]))
                {
                    junkDict.Add(arr[i + 1], quantity);
                }
                else
                {
                    junkDict[arr[i + 1]] += quantity;
                }
            }
        }
    }
}