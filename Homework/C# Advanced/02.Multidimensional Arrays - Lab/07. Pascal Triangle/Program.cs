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
        int [][] arr = new int[n][];
        
        int cols = 1;


        for (int row = 0; row < arr.Length; row++)
        {
            arr[row] = new int[cols];
            arr[row][0] = 1;
            arr[row][arr[row].Length - 1] = 1;
            

            if(row > 1)
            {
                for (int col = 1; col < arr[row].Length - 1; col++)
                {
                    int[] prevRow = arr[row - 1];
                    int firstNum = prevRow[col];
                    int secNum = prevRow[col - 1]; 
                    arr[row][col] = firstNum + secNum; 

                }
            }
            cols++;
        }
        foreach(var item in arr)
        {
            Console.WriteLine(String.Join(" ", item));
        }
    }
}