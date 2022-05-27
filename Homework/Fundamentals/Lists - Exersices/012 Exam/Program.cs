using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        double priceTshirt = double.Parse(Console.ReadLine());
        double discountPrice = double.Parse(Console.ReadLine());

        double shorts = priceTshirt * 0.75;
        double socks = shorts * 0.2;
        double shoes = (priceTshirt + shorts) * 2;
        double total = priceTshirt + shorts + socks + shoes;
        total = total - (total * 0.15);
        double diff = Math.Abs(discountPrice - total);

        if (total >= discountPrice)
        {
            Console.WriteLine("Yes, he will earn the world-cup replica ball!");
            Console.WriteLine($"His sum is {total:F2} lv.");

        } else
        {
            Console.WriteLine("No, he will not earn the world-cup replica ball.");
            Console.WriteLine($"He needs {diff:F2} lv. more.");
        }

    }
}