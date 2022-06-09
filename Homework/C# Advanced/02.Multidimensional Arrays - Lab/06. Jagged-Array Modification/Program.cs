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
        int rowNum = int.Parse(Console.ReadLine());
        int[][] matrix = new int[rowNum][]; 

        for (int row = 0; row < matrix.Length; row++)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            matrix[row] = new int[arr.Length]; 

            for (int col = 0; col < arr.Length; col++)
            {
                matrix[row][col] = arr[col]; 
            }
        }
        string[] command = Console.ReadLine().Split().ToArray();
        while (command[0] != "END")
        {

            string text = command[0];
            int row = int.Parse(command[1]);
            int col = int.Parse(command[2]);
            int num = int.Parse(command[3]);

            if (matrix.Length > row && row >= 0 && col >= 0 && matrix[row].Length > col)
            {
                if (text == "Add")
                {
                    matrix[row][col] += num;
                }
                else if (text == "Subtract")
                {
                    matrix[row][col] -= num;
                }
            } 
            else
            {
                Console.WriteLine("Invalid coordinates");
            }
            command = Console.ReadLine().Split().ToArray();


        }

        foreach (var item in matrix)
        {
            Console.WriteLine(String.Join(" ", item));
        }
    }
}