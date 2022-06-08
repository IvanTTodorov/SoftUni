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
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int[] number = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            for (int j = 0; j < n; j++)
            {

                matrix[i, j] = number[j];
            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i]; 
        }
        Console.WriteLine(sum);
    }
} 
