using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] command = Console.ReadLine().Split(":|:");

            while (command[0] != "Reveal")
            {
                if (command[0] == "InsertSpace")
                {
                    input = InsertSpace(command, input);
                    Console.WriteLine(input);

                }
                else if (command[0] == "Reverse")
                {
                    if (Reverse(command, input) == "error")
                    {
                        Console.WriteLine("error");
                    }
                    else
                    {
                        input = Reverse(command, input);
                        Console.WriteLine(input);
                    }

                }
                else if (command[0] == "ChangeAll")
                {
                    input = ChangeAll(input, command);
                    Console.WriteLine(input);
                }


                command = Console.ReadLine().Split(":|:");
            }
            Console.WriteLine($"You have a new text message: {input}");
        }
        public static string InsertSpace(string[] command, string input)
        {
            int index = int.Parse(command[1]);
            input = input.Insert(index, " ");
            return input;
        }
        public static string Reverse(string[] command, string input)
        {

                if (input.Contains(command[1]))
                {
                    char[] newWord = command[1].ToCharArray();
                    Array.Reverse(newWord);
                    string reversingWord = new string(newWord);
                int index = input.IndexOf(command[1]); 
                input = input.Remove(index, command[1].Length);
                input = input.Insert(input.Length, reversingWord);
                }
                else
                {
                    input = "error";
                }
            
            return input;

        }
        public static string ChangeAll(string input, string[] command)
        {
            string oldLetter = command[1];
            string newLetter = command[2];
            while (input.Contains(oldLetter))
            {
                input = input.Replace(oldLetter, newLetter);
            }
            return input;
        }
    }
}
