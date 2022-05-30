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

            string title = Console.ReadLine();
            string content = Console.ReadLine();
            string comment = String.Empty;

            Console.WriteLine($"<h1>");
            Console.WriteLine("     "+  title);
            Console.WriteLine($"</h1>");
            Console.WriteLine($"<article>");
            Console.WriteLine("     "+  content);
            Console.WriteLine($"</article>");

            while ((comment = Console.ReadLine()) != "end of comments")
            {
                Console.WriteLine($"<div>");
                Console.WriteLine("     "+  comment);
                Console.WriteLine($"</div>");
            }

        }
    }
}