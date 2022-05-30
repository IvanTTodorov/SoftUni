using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        int n = int.Parse(Console.ReadLine());
        int[] newArray1 = new int[n];
        int[] newArray2 = new int[n];


        for (int i = 0; i < n; i++)
        {
            int[] arrayNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

           
            if (i % 2 != 0)
            {
                newArray1[i] = arrayNumbers[0];
                newArray2[i] = arrayNumbers[1];
            } else
            {
                newArray1[i] = arrayNumbers[1];
                newArray2[i] = arrayNumbers[0];
            }
        }
        Console.WriteLine(String.Join(' ', newArray2));
        Console.WriteLine(String.Join(' ', newArray1));





    }
}