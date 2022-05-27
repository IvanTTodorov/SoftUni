using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        string input = Console.ReadLine();
        int maxGoals = 0;
        string bestPlayer = String.Empty;
        while (input != "END")
        {
            string name = input;
            int goals = int.Parse(Console.ReadLine());    
            if (goals > maxGoals)
            {
                bestPlayer = name;
                maxGoals = goals; 
            }
            if (goals >= 10)
            {
                break;
            }
             
            input = Console.ReadLine();
        }
        Console.WriteLine($"{bestPlayer} is the best player!");
            if (maxGoals >= 3)
        {
            Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
        } 
            else
        {
            Console.WriteLine($"He has scored {maxGoals} goals.");
        }
    }
}