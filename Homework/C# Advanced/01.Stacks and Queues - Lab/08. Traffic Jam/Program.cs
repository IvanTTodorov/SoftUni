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
        Queue<string> cars = new Queue<string>();
        int n = int.Parse(Console.ReadLine());
        string command = string.Empty;
        int totalCars = 0;

        while ((command = Console.ReadLine()) != "end")
        {
            if (command != "green")
            {
                cars.Enqueue(command);
            }
            else if (command == "green")
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars.Count > 0)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        totalCars++;
                    }
                }

            }
        }
        Console.WriteLine($"{totalCars} cars passed the crossroads.");
    }
}
