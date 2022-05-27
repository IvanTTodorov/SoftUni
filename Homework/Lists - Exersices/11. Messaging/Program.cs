using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string text = Console.ReadLine();

        for (int i = 0; i < numbers.Count; i++)
        {
            int currentNumber = numbers[i];
            int sum = CalculateIndex(currentNumber);

            char currentChar = GetCharFromMessage(sum, text);
            Console.Write(currentChar);

            int index = CalculateRealIndex(sum, text);
            string newText = text.Remove(index, 1);
            text = newText;
        }
        Console.WriteLine();

    } 
    static int CalculateIndex (int currentNumber)
    {
        int sum = 0;
        while (currentNumber > 0)
        {
            int number = currentNumber % 10;
            sum += number;
            currentNumber = currentNumber / 10;
        }
        return sum;
    } 
    static char GetCharFromMessage (int sum, string text)
    {
        int count = 0;
        
            for (int y = 0; y < sum; y++)
            {
                count++;
                if (count == text.Length)
                {
                    count = 0;
                }
            }
        
        char currentChar = text[count];
        return currentChar;
    } 
    static int CalculateRealIndex (int sum, string text)
    {
        int index = 0;
        for (int i = 0; i < sum; i++)
        {
            index++; 
            if (index == text.Length)
            {
                index = 0;
            } 
        }
        return index;
    }
}