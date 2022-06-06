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
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = input[0];
        int s = input[1];

        int valid = input[2];

        Queue <int> nums = new Queue<int>();    
        for (int i = 0; i < n; i++)
        {
            nums.Enqueue(numbers[i]);
        }
        for (int i = 0; i < s; i++)
        {
            nums.Dequeue();
        }
        if (nums.Contains(valid))
        {
            Console.WriteLine("true");
        }
        else if (!nums.Contains(valid))
        {
            if (nums.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(nums.Min());
            }
        }
    }
}

