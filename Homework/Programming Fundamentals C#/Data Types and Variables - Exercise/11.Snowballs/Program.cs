using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)

    {
        byte number = byte.Parse(Console.ReadLine());
        BigInteger snowballValue = 0;
        BigInteger maxValue = int.MinValue;

        short maxSnowballSnow = 0;
        short maxSnowballTime = 0;
        byte maxSnowballQuality = 0;




        for (int i = 0; i < number; i++)
        {
            short snowballSnow = short.Parse(Console.ReadLine());
            short snowballTime = short.Parse(Console.ReadLine());
            byte snowballQuality = byte.Parse(Console.ReadLine());

            snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);   

            if (maxValue < snowballValue)
            {
                maxValue = snowballValue;
                maxSnowballSnow = snowballSnow;
                maxSnowballQuality = snowballQuality;
                maxSnowballTime = snowballTime; 
            }


        }

        Console.WriteLine($"{maxSnowballSnow} : {maxSnowballTime} = {maxValue} ({maxSnowballQuality})");
         
    }
}