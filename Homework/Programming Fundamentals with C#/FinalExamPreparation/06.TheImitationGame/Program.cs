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
            string input = Console.ReadLine(); 
            string[] command = Console.ReadLine().Split('|');

            while(command[0] != "Decode")
            {
                if(command[0] == "Move")
                {
                    int index = int.Parse(command[1]);
                    string letters = input.Substring(0, index);
                    input = input.Remove(0, index);
                    input = input.Insert(input.Length, letters); 
                }
                else if( command[0] == "Insert")
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    input = input.Insert(index, value);
                }
                else if(command[0] == "ChangeAll")
                {
                    if(input.Contains(command[1]))
                    {
                        input = input.Replace(command[1], command[2]); 
                    }
                }
                command = Console.ReadLine().Split('|');
            }
            Console.WriteLine($"The decrypted message is: {input}");
        }
    }
}