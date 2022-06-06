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
        Stack<int> numbers = new Stack<int>();  
        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            if (input[0] == 1)
            {
                numbers.Push(input[1]); 
            }
            else if (input[0] == 2)
            {
                numbers.Pop();
            }
            else if(input[0] == 3 && numbers.Count > 0)
            {
                Console.WriteLine(numbers.Max());
            } else if (input[0] == 4 && numbers.Count > 0)
            {
                Console.WriteLine(numbers.Min());
            }
        }
        Console.WriteLine(String.Join(", ", numbers));
     
    }
}
