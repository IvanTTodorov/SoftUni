using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Citizens> citizens = new List<Citizens>();
            List<Rebel> rebels = new List<Rebel>();


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] personInfo = Console.ReadLine().Split();

                if (personInfo.Length == 4)
                {
                    Citizens citizen = new Citizens(personInfo[0], personInfo[1], personInfo[2], personInfo[3]);
                    citizens.Add(citizen);
                }
                else if (personInfo.Length == 3)
                {
                    Rebel rebel = new Rebel(personInfo[0], personInfo[1], personInfo[2]);
                    rebels.Add(rebel);
                }
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                foreach (var item in citizens)
                {
                    if (input == item.Name)
                    {
                        item.BuyFood();
                        break;
                    }
                }
                foreach (var item in rebels)
                {
                    if (input == item.Name)
                    {
                        item.BuyFood();
                        break;
                    }
                }
            }
             
            int total = 0;
            foreach (var item in citizens)
            {
                if (item.Food > 0)
                {
                    total += item.Food;
                }
            }
            foreach (var item in rebels)
            {
                if (item.Food > 0)
                {
                    total += item.Food;
                }
            }

            Console.WriteLine(total);
        }
    }
}
