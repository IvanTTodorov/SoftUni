using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        int[] numbers = Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray();


        int length = 1;
        int maxLength = 0;
        int start = 0;
        int bestStart = 0;

        for (int i = 1; i < numbers.Length; i++)
        { 
                if (numbers[i] == numbers[i - 1])
            {
                length++;
                
            }
            else
            {
                length = 1;
                start = i;

            }
                if (length > maxLength)
            {
                maxLength = length;
                bestStart = start;
            }
        }  
         
        for (int i = bestStart; i < bestStart + maxLength; i++)
        {
            Console.Write(numbers[i] + " ") ;
        }
    }
}