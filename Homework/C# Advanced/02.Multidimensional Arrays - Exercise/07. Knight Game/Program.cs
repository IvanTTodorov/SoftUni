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
        char[,] matrix = new char[n, n];
        int countReplaced = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string arr = Console.ReadLine();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = arr[col];
            }
        }

        while (true)
        {
            List<int> best = new List<int>();
            int bestAttacks = 0; 

          
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        int attacks = 0;
                        char symbol = matrix[row, col];
                        if (symbol == 'K')
                        {
                            if (IsValid(matrix, row + 2, col + 1))
                            {
                                if (matrix[row, col] == matrix[row + 2, col + 1])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row + 2, col - 1))
                            {
                                if (matrix[row, col] == matrix[row + 2, col - 1])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row - 2, col + 1))
                            {
                                if (matrix[row, col] == matrix[row - 2, col + 1])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row - 2, col - 1))
                            {
                                if (matrix[row, col] == matrix[row - 2, col - 1])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row + 1, col + 2))
                            {
                                if (matrix[row, col] == matrix[row + 1, col + 2])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row + 1, col - 2))
                            {
                                if (matrix[row, col] == matrix[row + 1, col - 2])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row - 1, col + 2))
                            {
                                if (matrix[row, col] == matrix[row - 1, col + 2])
                                {
                                    attacks++;
                                }
                            }
                            if (IsValid(matrix, row - 1, col - 2))
                            {
                                if (matrix[row, col] == matrix[row - 1, col - 2])
                                {
                                    attacks++;
                                }
                            }
                        }

                        if (attacks > bestAttacks)
                        {
                            bestAttacks = attacks;
                            best.RemoveRange(0, best.Count);
                            best.Add(row);
                            best.Add(col);
                        }
                    }
                }

                if (bestAttacks == 0)
                {
                    Console.WriteLine(countReplaced);
                    break;
                }
                else if (bestAttacks > 0)
                {
                    matrix[best[0], best[1]] = 'O';
                countReplaced++;
                }
        }
    }

    static bool IsValid (char[,] matrix, int row, int col)
    {
        return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
    }
}

        
         
       

