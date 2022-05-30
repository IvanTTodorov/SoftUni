using System;

class Program
{
    static void Main(string[] args)

    { 

        byte n = byte.Parse(Console.ReadLine()); 

       
        int totalSum = 0;

        for (int i = 1; i <= n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            totalSum = (int)letter + totalSum;
            

        } 
        Console.WriteLine($"The sum equals: {totalSum}");




    }
}