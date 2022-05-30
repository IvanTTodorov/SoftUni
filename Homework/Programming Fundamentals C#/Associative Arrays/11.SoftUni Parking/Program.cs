using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> information = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                Command(input, information); 

            }
            foreach(var item in information)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }

        }
        public static void Command(string[] input, Dictionary<string, string> information)
        {
            

            if (input[0] == "register")
            {
                string name = input[1];
                string licenseNumber = input[2];

                if (!information.ContainsKey(name))
                {
                    information.Add(name, licenseNumber);
                    Console.WriteLine($"{name} registered {licenseNumber} successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: already registered with plate number {licenseNumber}");
                }
            }
            else if (input[0] == "unregister")
            {
                string name = input[1];

                if (!information.ContainsKey(name))
                {
                    Console.WriteLine($"ERROR: user {name} not found");
                }
                 else
                {
                    Console.WriteLine($"{name} unregistered successfully");
                    information.Remove(name);    
                }
                }
        }
    }
}