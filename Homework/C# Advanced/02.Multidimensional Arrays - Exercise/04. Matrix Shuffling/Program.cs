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
        string[,] matrix = new string[numbers[0], numbers[1]];
        string[,] matrix1 = new string[1, numbers[1]];



        string temp = string.Empty;


        for (int row = 0; row < numbers[0]; row++)
        {
            string[] arr = Console.ReadLine().Split();
            for (int col = 0; col < numbers[1]; col++)
            {
                matrix[row, col] = (arr[col]);
            }
        }

        string command = string.Empty;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] input = command.Split();
            string swap = input[0];
            if (input[0] != "swap" || input.Length > 5)
            {
                Console.WriteLine("Invalid input!");
                continue;
            }
            int row1 = int.Parse(input[1]);
            int col1 = int.Parse(input[2]);
            int row2 = int.Parse(input[3]);
            int col2 = int.Parse(input[4]);

            if (row1 > numbers[0] || col1 > numbers[1] || row2 > numbers[0] || col2 > numbers[1])
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                matrix1[0, 0] = matrix[row2, col2];
                matrix[row2, col2] = matrix[row1, col1];
                matrix[row1, col1] = matrix1[0, 0];
                Print(matrix); 
            }
        }
    }

    static void Print(string[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();

        }
    }
}
