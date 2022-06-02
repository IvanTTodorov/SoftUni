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

        string[] numberOperations = Console.ReadLine().Split();
        Stack<string> stack = new Stack<string>();
        Stack<string> stackReverse = new Stack<string>();      

        int result = 0;

        for (int i = 0; i < numberOperations.Length; i++)
        {
            if (i % 2 == 0)
            {
                stack.Push(numberOperations[i]);
            }
        }

        while (stack.Count > 0)
        {
           stackReverse.Push(stack.Pop());
        }

        for (int i = 0; i < numberOperations.Length; i++)
        { 
            if ( i == 0)
            {
                result += int.Parse(stackReverse.Pop());
            }
            if (numberOperations[i] == "+")
            {
                result += int.Parse(stackReverse.Pop());
            } 
            else if (numberOperations[i] == "-")
            {
                result -= int.Parse(stackReverse.Pop());
            }
        }

        Console.WriteLine(result);

      
    }
}
        

