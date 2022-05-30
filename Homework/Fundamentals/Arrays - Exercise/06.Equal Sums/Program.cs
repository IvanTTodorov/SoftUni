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
       

        for (int i = 0; i < numbers.Length; i++)
        {
            int sumLeft = 0;
            int sumRight = 0;
             
            for (int j = 0; j < i; j++)
            {
                sumLeft += numbers[j];
            }
            for (int k = i + 1; k < numbers.Length; k++)
            {
                sumRight += numbers[k];
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine(i);
                return;
            }
        }
        Console.WriteLine("no");

    }
}