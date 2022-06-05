using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue <int> newNumbers = new Queue<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] %2 == 0)
            {
                newNumbers.Enqueue(numbers[i]);
            }
        }
        Console.WriteLine(String.Join(", ", newNumbers));
    }
}