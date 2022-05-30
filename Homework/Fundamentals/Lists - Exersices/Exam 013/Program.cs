using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        int n = int.Parse(Console.ReadLine());
        string seasons = Console.ReadLine();
        double sum = 0;

        if (seasons == "spring")
        {
            if (n <= 5)
            {
                sum = n * 50.00;
            }
            else
            {
                sum = n * 48.00;
            }
        }
        else if (seasons == "summer")
        {
            if (n <= 5)
            {
                sum = n * 48.50;
            }
            else
            {
                sum = n * 45.00;
            }
            sum = sum * 0.85;
        }
        else if (seasons == "autumn")
        {
            if (n <= 5)
            {
                sum = n * 60.00;
            }
            else
            {
                sum = n * 49.50;
            }
        }
       else if (seasons == "winter")
        {
            if (n <= 5)
            {
                sum = n * 86.00;
            }
            else
            {
                sum = n * 85.00;
            }
            sum = sum + (sum * 0.08);
        }
        Console.WriteLine($"{sum:F2} leva.");
    }
}