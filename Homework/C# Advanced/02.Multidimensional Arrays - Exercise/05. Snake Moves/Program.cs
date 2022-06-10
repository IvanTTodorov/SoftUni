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
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        char[,] symbol = new char[input[0], input[1]];
        int counter = 0;
        string text = Console.ReadLine();


        for (int row = 0; row < input[0]; row++)
        {

            
            if (row % 2 == 0)
            {
                for (int col = 0; col < input[1]; col++)
                {
                    if (counter == text.Length)
                    {
                        counter = 0;
                    }
                    symbol[row, col] = text[counter];
                    counter++;
                }
            }
            else
            {
                for (int col = input[1] - 1; col >= 0; col--)
                {
                    if (counter == text.Length)
                    {
                        counter = 0;
                    }
                    symbol[row, col] = text[counter];
                    counter++;
                }
            }
            for (int i = 0; i < symbol.GetLength(1); i++)
            {
                Console.Write(symbol[row, i]);
            }
            Console.WriteLine();   
        }
    }
}