using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            while((command =Console.ReadLine()) != "end")
            {
                string reversed = string.Empty;
                for (int i = command.Length -1; i >= 0; i--)
                {
                    reversed += command[i];
                }
                Console.WriteLine($"{command} = {reversed}");
            }

        } 
      
    }
}