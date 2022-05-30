using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        int k = int.Parse(Console.ReadLine());
        int l = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int count = 0;


        for (int i = k; i <= 8; i++)
        {
            for (int j = 9; j >= l; j--)
            {
                for (int a = m; a <= 8 ; a++)
                {
                    for (int b = 9; b >= n; b--)
                    {
                        if (i % 2 == 0 && a % 2 == 0 && j % 2 != 0 && b % 2 != 0)
                        {
                            if (i == a && j ==b)
                            {
                                Console.WriteLine("Cannot change the same player.");

                            } 
                            else
                            {
                                Console.WriteLine($"{i}{j} - {a}{b}");
                                count++;
                            } 
                            if (count == 6)
                            {
                                return;
                            }
                        }
                    }
                }
            }
        }
    }
}