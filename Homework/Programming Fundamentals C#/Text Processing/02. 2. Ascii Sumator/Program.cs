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
            char first = char.Parse(Console.ReadLine()); 
            char second = char.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            int result = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] > first && text[i] < second)
                {
                    result += text[i];
                }
            }
            Console.WriteLine(result);
        }
    }
}