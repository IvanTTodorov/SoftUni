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
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
        Stack<int> stack = new Stack<int>(numbers);

       
        string command = String.Empty;
        while ((command = Console.ReadLine().ToLower()) != "end")
        {  
            string[] cmdItems = command.Split();
            string commandText = cmdItems[0];
            
             
            if (commandText == "add")
            {
                stack.Push(int.Parse(cmdItems[1]));
                stack.Push(int.Parse(cmdItems[2])); 
            } 
            else
            {
                int index = int.Parse(cmdItems[1]); 
                if (index < stack.Count)
                {
                    for (int i = 0; i < index; i++)
                    {
                        stack.Pop();
                    }
                } 
                
            }
        }
        Console.WriteLine($"Sum: {stack.Sum()}");
    }
}