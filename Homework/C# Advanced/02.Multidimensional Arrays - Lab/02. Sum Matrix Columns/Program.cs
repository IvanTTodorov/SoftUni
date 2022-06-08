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
        int[] nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int first = nums[0];
        int second = nums[1];
        int[,] matrix = new int[first, second];
        int sum = 0;

        for (int i = 0; i < first; i++)
        {
            nums = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < second; j++)
            {

                matrix[i, j] = nums[j];
            }
        }

        for (int i = 0; i < second; i++)
        {
            for (int j = 0; j < first; j++)
            {
                sum += matrix[j, i];
            }
            Console.WriteLine(sum);
            sum = 0;
        }
    }
}