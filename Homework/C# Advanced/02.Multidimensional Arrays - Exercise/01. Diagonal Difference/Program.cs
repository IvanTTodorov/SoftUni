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
        int sum1 = 0; 
        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = numbers[col]; 
            }
        }
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, i];
            sum1 += matrix[i, matrix.GetLength(1) - i - 1]; 
        }
        Console.WriteLine(Math.Abs(sum - sum1));
    }
}