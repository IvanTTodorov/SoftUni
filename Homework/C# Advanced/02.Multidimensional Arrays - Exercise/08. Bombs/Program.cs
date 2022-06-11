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
        int countAliveCells = 0;
        


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = arr[col];
            }
        }

        string[] commands = Console.ReadLine().Split();
        for (int i = 0; i < commands.Length; i++)
        {
            string[] command1 = commands[i].Split(',');
            int num1 = int.Parse(command1[0]);
            int num2 = int.Parse(command1[1]);
            int value = matrix[num1, num2];

            if (value > 0)
            {
                if (Exist(matrix, num1 - 1, num2 - 1) && matrix[num1 - 1, num2 - 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1 - 1, num2 - 1] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1 - 1, num2) && matrix[num1 - 1, num2] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1 - 1, num2] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1 - 1, num2 + 1) && matrix[num1 - 1, num2 + 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1 - 1, num2 + 1] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1 + 1, num2 + 1) && matrix[num1 + 1, num2 + 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1 + 1, num2 + 1] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1 + 1, num2) && matrix[num1 + 1, num2] > 0
                  && matrix[num1, num2] > 0)
                {
                    matrix[num1 + 1, num2] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1 + 1, num2 - 1) && matrix[num1 + 1, num2 - 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1 + 1, num2 - 1] -= matrix[num1, num2];
                }

                if (Exist(matrix, num1, num2 + 1) && matrix[num1, num2 + 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1, num2 + 1] -= matrix[num1, num2];
                }
                
                if (Exist(matrix, num1, num2 - 1) && matrix[num1, num2 - 1] > 0
                 && matrix[num1, num2] > 0)
                {
                    matrix[num1, num2 - 1] -= matrix[num1, num2];
                }
                matrix[num1, num2] = 0;

            }
        }

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                if (matrix[i,y] > 0)
                {
                    sum += matrix[i, y];
                    countAliveCells++;
                }
            }
        }

        Console.WriteLine($"Alive cells: {countAliveCells}");
        Console.WriteLine($"Sum: {sum}");
        Print(matrix);
        

        static void Print(int[,] matrix)
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
        static bool Exist(int[,] matrix, int num1, int num2)
        {
            return num1 >= 0 && num1 < matrix.GetLength(0) && num2 >= 0 && num2 < matrix.GetLength(1);
        }
    }
}
