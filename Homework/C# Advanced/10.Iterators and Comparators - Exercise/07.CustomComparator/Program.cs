using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int, int, int> func = (num1, num2) =>
              (num1 % 2 == 0) && (num2 % 2 != 0) ? -1 :
              (num1 % 2 != 0) && (num2 % 2 == 0) ? 1 :
              num1.CompareTo(num2);

            Array.Sort<int>(arr, new Comparison<int>(func));
            Console.WriteLine(String.Join(" ", arr));

        }
    }
}