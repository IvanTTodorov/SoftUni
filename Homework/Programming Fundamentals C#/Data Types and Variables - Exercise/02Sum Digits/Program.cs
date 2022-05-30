using System;

class Program
{
    static void Main(string[] args)

    { 

        int number = int.Parse(Console.ReadLine());

        int totalSum = 0; 
         
        while (number > 0)
        {
            totalSum = (number % 10) + totalSum; 
            number /= 10;   
        }    
         Console.WriteLine(totalSum);

     }
} 