using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        double Numpaper = double.Parse(Console.ReadLine());
        double Numrolls = double.Parse(Console.ReadLine());
        double Litersglue = double.Parse(Console.ReadLine());
        int percentDiscount = int.Parse(Console.ReadLine());
         
        double totalSum = (Numpaper * 5.80) + (Numrolls * 7.20) + (Litersglue * 1.20);
        double discount = (totalSum * percentDiscount) / 100;
        totalSum -= discount;

        Console.WriteLine($"{totalSum:F3}");
    }
}