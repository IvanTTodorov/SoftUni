using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        List<int> digits = new List<int>();
        List<string> symbols = new List<string>();
        List<int> takeList = new List<int>();
        List<int> skipList = new List<int>();
        int maxLength = 0;
        List<string> newList = new List<string>();

        IsDigit(text, digits, symbols);
        OddOrEven(digits, takeList, skipList);

        maxLength = MaxLength(takeList, skipList, maxLength);

        for (int i = 0; i <= maxLength; i++)
        {
            if (takeList.Count >= 0)
            {
                for (int y = 0; y <= takeList[0] - 1; y++)
                {
                    newList.Add(symbols[0]);
                    symbols.RemoveAt(0);
                }
                takeList.RemoveAt(0);
            }

            if (skipList.Count >= 0)
            {
                for (int e = 0; e <= skipList[0] - 1; e++)
                {
                    symbols.RemoveAt(0);
                }
                skipList.RemoveAt(0);
            }
        }
        Console.WriteLine(String.Join("", newList.ToArray()));
    }

    static int MaxLength(List<int> takeList, List<int> skipList, int maxLength)
    {
        if (takeList.Count >= skipList.Count)
        {
            maxLength = takeList.Count - 1;
        }
        else if (takeList.Count < skipList.Count)
        {
            maxLength = skipList.Count - 1;
        }
        return maxLength;
    }

    static void IsDigit(string text, List<int> digits, List<string> symbols)
    {
        for (int i = 0; i < text.Length; i++)
        {
            if (char.IsDigit(text[i]))
            {
                digits.Add(int.Parse(text[i].ToString()));
            }
            else
            {
                symbols.Add(text[i].ToString());
            }

        }
    }
    static void OddOrEven(List<int> digits, List<int> takeList, List<int> skipList)
    {
        for (int i = 0; i < digits.Count; i++)
        {
            if (i % 2 == 0)
            {
                takeList.Add(digits[i]);
            }
            else
            {
                skipList.Add(digits[i]);
            }
        }
    }
}