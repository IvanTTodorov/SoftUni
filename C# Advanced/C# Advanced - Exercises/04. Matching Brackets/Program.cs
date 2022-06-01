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
        string numberOperations = Console.ReadLine();
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < numberOperations.Length; i++)
        {
            if(numberOperations[i] == '(')
            {
                stack.Push(i);
            } 
            else  if (numberOperations[i] == ')')
            {
                int startIndex = stack.Pop();
                int endIndex = i; 
                string subExpression = numberOperations.Substring(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(subExpression);
            }
        } 

        
        
        
    }
} 