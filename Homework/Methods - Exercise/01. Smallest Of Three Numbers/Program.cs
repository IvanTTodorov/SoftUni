using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        WhichOneIsTheSmallest(first, second, third);    

    } 
    static void WhichOneIsTheSmallest (int first, int second, int third)
    {
        int minNumber = int.MinValue; 

        if (minNumber <  first)
        {
            minNumber = first; 
            if (minNumber > second)
            {
                minNumber = second; 
            } 
            if (minNumber > third)
            {
                minNumber = third;
            } 
        }
        Console.WriteLine(minNumber);
    }
}