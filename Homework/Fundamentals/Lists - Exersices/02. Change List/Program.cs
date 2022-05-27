using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
        string text;
        

        while (((text = Console.ReadLine())!= "end"))
        {
            string[] input = text.Split(" "); 

           

                if (input[0] == "Delete")
                {
                    numbers.RemoveAll(i => i == int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {
                    numbers.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }
        Console.WriteLine(String.Join(" ", numbers));
    }
       
    }
