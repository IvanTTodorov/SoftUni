using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<string> list = Console.ReadLine()
            .Split("|", StringSplitOptions.RemoveEmptyEntries)
            .Reverse()
            .ToList();

        List<string> result = new List<string>();

        for (int i = 0; i < list.Count; i++)
        {
            List<string> number = list[i].Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int j = 0; j < number.Count; j++)

            {
                result.Add(number[j]);
            }
        }
        Console.WriteLine(String.Join(' ', result));
    }
}
