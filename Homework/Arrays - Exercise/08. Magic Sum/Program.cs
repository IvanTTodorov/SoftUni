using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        int[] numbers = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToArray();
        int sum = int.Parse(Console.ReadLine());

        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if ( numbers[i] + numbers[j] == sum)
                {
                    Console.WriteLine(String.Join(" ", numbers[i], numbers[j]));    
                }
            }
        }



    }
}