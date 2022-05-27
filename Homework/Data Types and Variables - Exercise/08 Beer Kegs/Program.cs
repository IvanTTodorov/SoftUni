using System;

class Program
{
    static void Main(string[] args)

    { 
        byte number = byte.Parse(Console.ReadLine());

        float maxVolume = float.MinValue;

        String maxKeg = "";
        

        for (int i = 0; i < number; i++)
        {
            String model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());  

            float volume = (float)(Math.PI * Math.Pow(radius, 2) * height);
             
            if (volume > maxVolume)
            {
                maxVolume = volume;
                maxKeg = model;
            }
        }
        Console.WriteLine(maxKeg);
         




    }
} 
