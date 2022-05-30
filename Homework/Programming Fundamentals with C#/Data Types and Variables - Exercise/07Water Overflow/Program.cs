using System;

class Program
{
    static void Main(string[] args)

    {
        byte n = byte.Parse(Console.ReadLine());
        int capacity = 255;
        int total = 0;
         
        for (int i = 0; i < n; i++)
        {
            int quantities = int.Parse(Console.ReadLine());  
            if (capacity < quantities + total)
            {
                Console.WriteLine("Insufficient capacity!");
            }   
            else
            {
                total += quantities; 
            }
        }
        Console.WriteLine(total);



    }
}