using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
       
        HashSet<int> firstNums = new HashSet<int>();
        HashSet<int> secondNums = new HashSet<int>();
        HashSet<int> finalHasSet = new HashSet<int>(); 

        for (int i = 0; i < numbers[0]; i++)
        {
            int number = int.Parse(Console.ReadLine());
            firstNums.Add(number);
            
        } 
        for (int i = 0; i < numbers[1]; i++)
        {

            int number = int.Parse(Console.ReadLine());
            secondNums.Add(number);
        }
        foreach (var item in firstNums)
        {
            if (secondNums.Contains(item))
            {
                finalHasSet.Add(item);
            }
        }
        Console.WriteLine(string.Join(" ", finalHasSet));
        
    }
}