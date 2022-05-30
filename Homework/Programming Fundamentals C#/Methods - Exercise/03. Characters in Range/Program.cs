using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        char first = char.Parse(Console.ReadLine());
        char second = char.Parse(Console.ReadLine());
        BetweenChars(first, second);
    }
    static void BetweenChars(char first, char second)
    {
        if (second < first)
        {
            for (int i = second + 1 ; i < first; i++)
            {
                Console.Write((char)i + " ");
            }
        }
        else
        {
            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
          
    }
}