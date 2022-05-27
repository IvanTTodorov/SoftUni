using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < text[i].Length; j++)
                {
                    Console.Write(text[i]);
                }
            }
        }
    }
}