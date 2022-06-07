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
        string input = Console.ReadLine();
        Stack<char> firstBrackets = new Stack<char>();



        foreach (var bracket in input)
        {
            if (bracket == '(' || bracket == '{' || bracket == '[')
            {
                firstBrackets.Push(bracket);
            }

            if (firstBrackets.Count == 0)
            {
                Console.WriteLine("NO");
                return;
            }

            else if (bracket == ')' || bracket == '}' || bracket == ']')
            {
                char symbol = firstBrackets.Pop();
                if ((symbol == '(' && bracket == ')')
                    || (symbol == '{' && bracket == '}')
                    || (symbol == '[' && bracket == ']'))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }


            }
        }
        Console.WriteLine("YES");
    }
}