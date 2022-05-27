using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
         
        Console.WriteLine(MiddleElements(input));
        

    }
    static string MiddleElements(string input)
    {
        int lenght = input.Length;
        string result = " ";

        if (lenght % 2 == 0)
        {
            result = input[input.Length / 2 - 1 ].ToString() + input[lenght / 2].ToString();
        }
        else
        {
            result = input[input.Length / 2].ToString();
        }
        return result;
    }
} 

