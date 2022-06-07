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
        int n = int.Parse(Console.ReadLine());
        StringBuilder sb = new StringBuilder();
        List<string> lastStrings = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(); 
             
            if (command[0] == "1")
            {
                lastStrings.Add(sb.ToString()); 
                sb.Append(command[1]);
            }  
            else if (command[0] == "2")
            {
                lastStrings.Add(sb.ToString());
                int indexLenght = int.Parse(command[1]);
                sb.Remove(sb.Length - indexLenght, indexLenght);
            }
            else if (command[0] == "3")
            {
                int index = int.Parse(command[1]);
                string text = sb.ToString();
                char output = text[index - 1];
                Console.WriteLine(output);
            }
            else if (command[0] == "4")
            {
                sb.Remove(0, sb.Length);
                sb.Append(lastStrings[lastStrings.Count - 1]);
                lastStrings.RemoveAt(lastStrings.Count - 1);
            }

        }
         
        
    }
}