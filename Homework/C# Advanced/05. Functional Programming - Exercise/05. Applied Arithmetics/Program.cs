using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Func<int[], int[]> add = number =>
        {
            for (int i = 0; i < number.Length; i++)
            {
                number[i] += 1;
            }
            return number;
        };
        Func<int[], int[]> multiply = number =>
       {
           for (int i = 0; i < number.Length; i++)
           {
               number[i] *= 2;
           }
           return number;
       };
        Func<int[], int[]> subtract = number =>
        {
            for (int i = 0; i < number.Length; i++)
            {
                number[i] -= 1;
            }
            return number;
        };

        Action<int[]> print = numbers => Console.WriteLine(string.Join(" ", numbers));

        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        string command = Console.ReadLine();

        while (command != "end")
        {
            if (command == "add")
            {
                    add(numbers);
            }
            else if (command == "multiply")
            {
                    multiply(numbers); 
            }
            else if (command == "subtract")
            {

                    subtract(numbers);
            }
            else if (command == "print")
            {
                print(numbers);
            }
            command = Console.ReadLine();
        }






    }
}