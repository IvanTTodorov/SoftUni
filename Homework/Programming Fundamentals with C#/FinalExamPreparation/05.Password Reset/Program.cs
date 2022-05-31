using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] command = Console.ReadLine().Split().ToArray();

            while (command[0] != "Done")
            {

                if (command[0] == "TakeOdd")
                {
                    char[] numbers = text.Where((letter, index) => index % 2 != 0).ToArray();
                    text = String.Join("", numbers);

                    Console.WriteLine(text);
                }
                if (command[0] == "Cut")
                {
                    text = text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                    Console.WriteLine(text);
                }

                if (command[0] == "Substitute")
                {
                    if (text.Contains(command[1]))
                    {
                       text = text.Replace(command[1], command[2]);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine($"Your password is: {text}");
        }
    }
}