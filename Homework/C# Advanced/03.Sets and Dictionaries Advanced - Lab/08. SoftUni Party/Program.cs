using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string firstCommand = Console.ReadLine();

        HashSet<string> vip = new HashSet<string>();
        HashSet<string> regular = new HashSet<string>();

        while (firstCommand != "PARTY")
        {
            string guests = firstCommand;

            if (IsValid(guests) && char.IsLetter(guests[0]))
            {
                regular.Add(guests);
            }
            else if (IsValid(guests) && char.IsDigit(guests[0]))
            {
                vip.Add(guests);
            }

            firstCommand = Console.ReadLine();
        }
        string secondCommand = Console.ReadLine();
        while (secondCommand != "END")
        {

            if (vip.Contains(secondCommand))
            {
                vip.Remove(secondCommand);
            }
            else if (regular.Contains(secondCommand))
            {
                regular.Remove(secondCommand);
            }
            secondCommand = Console.ReadLine();
        }

        int totalCount = regular.Count + vip.Count;

        Console.WriteLine(totalCount);
        if (vip.Count > 0)
        {
            foreach (var item in vip)
            {
                Console.WriteLine(item);
            }
        }
        if (regular.Count > 0)
        {
            foreach (var item in regular)
            {
                Console.WriteLine(item);
            }
        }
    }
    public static bool IsValid(string guests)
    {
        return guests.Length == 8;
    }
}