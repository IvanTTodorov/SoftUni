using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace IteratorsAndComparators
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine().Split();  
            CustomStack<string> stack = new CustomStack<string>();
            while (command[0] != "END")
            {
                if(command[0] == "Push")
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        string[] numbers = command[i].Split(",", StringSplitOptions.RemoveEmptyEntries);
                        for (int y = 0; y < numbers.Length; y++)
                        {
                            stack.Push(numbers[y]);
                        }
                    }
                    
                }  
                else if (command[0] == "Pop")
                {
                    stack.Pop();
                }

                command = Console.ReadLine().Split();
                
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
} 