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
        Queue <string> customers = new Queue<string>();
        int count = 0; 


        while (input != "End")
        {
           if(input != "Paid")
            {
                customers.Enqueue(input);
                count++; 
                
            }
           else if (input == "Paid")
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(customers.Dequeue());
                }
                count = 0; 
            }

            input = Console.ReadLine();
        }

        Console.WriteLine($"{customers.Count} people remaining.");
    }
}