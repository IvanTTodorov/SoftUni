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

        int[] num = Console.ReadLine().Split().Select(int.Parse).ToArray();
        char[,] matrix = new char[num[0], num[1]];
        int counter = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            char[] characters = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = characters[col];
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1 ; col++)
            {
                if (matrix[row,col] == matrix[row,col + 1] && matrix[row, col] == matrix[row + 1, col]
                    && matrix[row,col] == matrix[row + 1, col + 1])
                {
                    counter++;
                } 
            }
        }
        Console.WriteLine(counter);
    }
}