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

            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();

            for (int i = 0; i < n; i++)
            {
                int indexfirstIndexName = text.IndexOf('@');
                int indexSecondIndexName = text.IndexOf('|');
                int indexfirstIndexAge = text.IndexOf('#');
                int indexSecondIndexAge = text.IndexOf('*');

                int nameLength = indexSecondIndexName - indexfirstIndexName;
                int ageLength = indexSecondIndexAge - indexfirstIndexAge;
                string name = text.Substring(indexfirstIndexName + 1, nameLength - 1 ); 
                string age = text.Substring(indexfirstIndexAge + 1, ageLength - 1 );

                Console.WriteLine($"{name} is {age} years old.");
                text = Console.ReadLine();
            }
        }
    }
}