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
        string[] commands = Console.ReadLine().Split();
        int counterCoals = 0;

        char[,] matrix = new char[n, n];
        int startRow = 0;
        int startCol = 0;
        int lastRow = 0;
        int lastCol = 0; 

        for (int row = 0; row < n; row++)
        {
            char[] input = Console.ReadLine().Split().Select(char.Parse).ToArray();
            for (int col = 0; col < n; col++)
            {
                matrix[row, col] = input[col];

                if (matrix[row, col] == 'c')
                {
                    counterCoals++;
                }
                if (matrix[row, col] == 's')
                {
                    startRow = row;
                    startCol = col;
                }
            }
        }



        for (int i = 0; i < commands.Length; i++)
        {
            if (commands[i] == "up")
            {
                if (IsValid(matrix, startRow - 1, startCol))
                {
                    if (matrix[startRow - 1, startCol] == 'c')
                    {
                        matrix[startRow - 1, startCol] = '*';
                        counterCoals--;
                        if (counterCoals == 0)
                        {
                            PrintCoals(startRow - 1, startCol);
                            return; 
                        }
                    }
                    if (matrix[startRow - 1, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow - 1}, {startCol})");
                        return;
                    }
                    startRow--;
                }
            }
            else if (commands[i] == "down")
            {
                if (IsValid(matrix, startRow + 1, startCol))
                {
                    if (matrix[startRow + 1, startCol] == 'c')
                    {
                        matrix[startRow + 1, startCol] = '*';
                        counterCoals--;
                        if (counterCoals == 0)
                        {
                            PrintCoals(startRow + 1, startCol);
                            return; 
                        }
                    }
                    if (matrix[startRow + 1, startCol] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow + 1}, {startCol})");
                        return; 
                    }
                    startRow++;

                }
            }
            else if (commands[i] == "right")
            {
                if (IsValid(matrix, startRow, startCol + 1))
                {
                    if (matrix[startRow, startCol + 1] == 'c')
                    {
                        matrix[startRow, startCol + 1] = '*';
                        counterCoals--;
                        if (counterCoals == 0)
                        {
                            PrintCoals(startRow, startCol + 1);
                            return;
                        }
                    }
                    if (matrix[startRow, startCol + 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol + 1})");
                        return;
                    }
                    startCol++;
                }
            }
            else if (commands[i] == "left")
            {
                if (IsValid(matrix, startRow, startCol - 1))
                {
                    if (matrix[startRow, startCol - 1] == 'c')
                    {
                        counterCoals--;
                        matrix[startRow, startCol - 1] = '*';
                        if (counterCoals == 0)
                        {
                            PrintCoals(startRow, startCol - 1);
                            return;
                        }
                    }
                    if (matrix[startRow, startCol - 1] == 'e')
                    {
                        Console.WriteLine($"Game over! ({startRow}, {startCol - 1 })");
                        return;
                    }
                    startCol--;
                }
            }    
             
             lastRow = startRow;
             lastCol = startCol;
        }

        Console.WriteLine($"{counterCoals} coals left. ({lastRow}, {lastCol})");

    }
    public static bool IsValid(char[,] matrix, int startRow, int startCol)
    {
        return (startRow >= 0 && startRow < matrix.GetLength(0)) && (startCol >= 0 && startCol < matrix.GetLength(1));
    }
    public static void PrintCoals(int startRow, int startCol)
    {
        Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");

    }
}

