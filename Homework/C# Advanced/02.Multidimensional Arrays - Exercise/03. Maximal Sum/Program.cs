using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Maximal_Sum
{
    public class Program
    {
        public static void Main()
        {
            var size = Console.ReadLine()
                .Split(new[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var rowsCount = size[0];
            var columnsCount = size[1];
            var matrix = new int[rowsCount, columnsCount];
            //fill in matrix
            for (int rows = 0; rows < rowsCount; rows++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ' }
                        , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int columns = 0; columns < columnsCount; columns++)
                {
                    matrix[rows, columns] = input[columns];
                }
            }
            //algorithm
            var rowIndex = 0;
            var colIndex = 0;
            var maxSum = 0;
            for (int startRow = 0; startRow < rowsCount - 2; startRow++)
            {
                for (var startColumn = 0; startColumn < columnsCount - 2; startColumn++)
                {
                    int currentRowSum = matrix[startRow, startColumn] + matrix[startRow, startColumn + 1] + matrix[startRow, startColumn + 2]
                              + matrix[startRow + 1, startColumn] + matrix[startRow + 1, startColumn + 1] + matrix[startRow + 1, startColumn + 2]
                              + matrix[startRow + 2, startColumn] + matrix[startRow + 2, startColumn + 1] + matrix[startRow + 2, startColumn + 2];

                    if (currentRowSum > maxSum)
                    {
                        maxSum = currentRowSum;
                        rowIndex = startRow;
                        colIndex = startColumn;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            Console.WriteLine($"{matrix[rowIndex, colIndex]} " +
                              $"{matrix[rowIndex, colIndex + 1]} " +
                              $"{matrix[rowIndex, colIndex + 2]}");

            Console.WriteLine($"{matrix[rowIndex + 1, colIndex]} " +
                              $"{matrix[rowIndex + 1, colIndex + 1]} " +
                              $"{matrix[rowIndex + 1, colIndex + 2]}");

            Console.WriteLine($"{matrix[rowIndex + 2, colIndex]} " +
                              $"{matrix[rowIndex + 2, colIndex + 1]} " +
                              $"{matrix[rowIndex + 2, colIndex + 2]}");

        }
    }
}