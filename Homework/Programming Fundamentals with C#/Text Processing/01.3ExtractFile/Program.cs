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
            var input = Console.ReadLine().Split('\\', StringSplitOptions.RemoveEmptyEntries);
            string info = input[input.Length - 1];

            string[] nameAndExtension = info.Split('.');
            string name = nameAndExtension[0];
            string extension = nameAndExtension[1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}