using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());  
        List <string> listOfGuests = new List<string>(); 
        FindGuests(n,listOfGuests);   

        static void FindGuests(int n, List<string> listOfGuests) 
        {
            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split();
                string name = text[0];
              
                if (text.Length == 3)
                {
                    if (listOfGuests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    } 
                    else
                    {
                        listOfGuests.Add(name);
                    }
                } 
                else
                {
                    if (listOfGuests.Contains(name))
                    {
                        listOfGuests.Remove(name);
                    } 
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    } 
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, listOfGuests));
            
        }
    }
} 
