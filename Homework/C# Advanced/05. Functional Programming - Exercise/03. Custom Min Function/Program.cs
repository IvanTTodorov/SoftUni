using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    { 
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Func<int[], int> smallestNumber = numbers =>
        {
            int minNum = int.MaxValue;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < minNum)
                {
                    minNum = input[i];
                }
            }
            return minNum;
        };
        Console.WriteLine(smallestNumber(input));
    }
}