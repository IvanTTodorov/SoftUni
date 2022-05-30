using System;

class Program
{
    static void Main(string[] args)

    {
        int wagons = int.Parse(Console.ReadLine());
        int[] total = new int[wagons];
        int sum = 0;  


        for (int i= 0; i < wagons; i++)
        {
            total [i] = int.Parse(Console.ReadLine());
            sum += total[i] ;
        }
        Console.WriteLine(String.Join(' ', total));
        Console.WriteLine(sum);

    }
}