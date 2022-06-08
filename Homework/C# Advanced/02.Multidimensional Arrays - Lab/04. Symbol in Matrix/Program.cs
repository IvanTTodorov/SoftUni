
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
        int number = int.Parse(Console.ReadLine());

        char[,] matrix = new char[number, number];

        for (int i = 0; i < number; i++)
        {
            string text = Console.ReadLine();
            for (int j = 0; j < number; j++)
            {
                matrix[i, j] = text[j];
            }
        }
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == symbol)
                {
                    Console.WriteLine($"({i}, {j})");
                    return;
                }
            }
        }
        Console.WriteLine($"{symbol} does not occur in the matrix");
    }
}


