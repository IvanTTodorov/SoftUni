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

            string text = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    power += int.Parse(text[i + 1].ToString());
                    sb.Append(text[i]);
                }
                else if (power == 0)
                {
                    sb.Append(text[i]);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);

        }
    }
}