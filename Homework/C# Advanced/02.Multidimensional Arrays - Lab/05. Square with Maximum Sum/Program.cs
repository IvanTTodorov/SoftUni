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
        int maxNumber = 0;
        List<int> bestMatrixfirstRow = new List<int>();
        List<int> bestMatrixSecodnRow = new List<int>();


        for (int i = 0; i < first; i++)
        {
            nums = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int j = 0; j < second; j++)
            {

                matrix[i, j] = nums[j];
            }
        }
        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                if (sum > maxNumber)
                {
                    maxNumber = sum;
                    bestMatrixfirstRow.RemoveRange(0, bestMatrixfirstRow.Count);
                    bestMatrixSecodnRow.RemoveRange(0, bestMatrixSecodnRow.Count);
                    bestMatrixfirstRow.Add(matrix[row, col]);
                    bestMatrixfirstRow.Add(matrix[row, col + 1]);
                    bestMatrixSecodnRow.Add(matrix[row + 1, col]);
                    bestMatrixSecodnRow.Add(matrix[row + 1, col + 1]);
                }


            }
        }
        Console.WriteLine(String.Join(" ", bestMatrixfirstRow));
        Console.WriteLine(String.Join(" ", bestMatrixSecodnRow));
        Console.WriteLine(maxNumber);

    }
}