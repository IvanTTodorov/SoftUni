using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                string number = string.Empty;
                Match match = Regex.Match(name, @"@{1}#+(?<product>[A-Z*][A-Za-z\d]{4,}[A-Z])@{1}#+");
                string nameProduct = match.Groups["product"].Value;
                if (nameProduct.Length == 0)
                {
                    Console.WriteLine("Invalid barcode");
                }
                else
                {

                    for (int j = 0; j < nameProduct.Length; j++)
                    {
                        if (char.IsDigit(nameProduct[j]))
                        {
                            number += nameProduct[j];
                        }
                    }
                    if (number.Length > 0)
                    {
                        Console.WriteLine($"Product group: {number}");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                }
            }

        }
    }
}