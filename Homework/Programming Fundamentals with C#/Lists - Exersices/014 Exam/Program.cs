using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        int days = int.Parse(Console.ReadLine());
        double totalLitres = 0;
        double totalDegrees = 0;

        for (int i = 0; i < days; i++)
        {
            double litres = double.Parse(Console.ReadLine());
            double degrees = double.Parse(Console.ReadLine());

            totalLitres += litres;
            totalDegrees = totalDegrees + (litres * degrees);

        }
        double AverageDegrees = totalDegrees / totalLitres;
        Console.WriteLine($"Liter: {totalLitres:F2}");
        Console.WriteLine($"Degrees: {AverageDegrees:F2}");



        if (AverageDegrees > 42)
        {
            Console.WriteLine("Dilution with distilled water!");
        }
        else if (AverageDegrees > 38 && AverageDegrees < 42)
        {
            Console.WriteLine("Super!");
        } else
        {
            Console.WriteLine("Not good, you should baking!");
        }
    }
}