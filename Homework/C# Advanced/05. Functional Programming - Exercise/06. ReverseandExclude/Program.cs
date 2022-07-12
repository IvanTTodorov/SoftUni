using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Func<int, int, bool> removingNumbers = (x, n) => x % n == 0; 
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        int[] result = numbers.Where(x => !removingNumbers(x, n)).Reverse().ToArray();

        Console.WriteLine(String.Join(" ", result));
    }
}