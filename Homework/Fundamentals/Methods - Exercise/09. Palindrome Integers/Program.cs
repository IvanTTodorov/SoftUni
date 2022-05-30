using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        PalindromeOrNot(input);

    }
    static void PalindromeOrNot(string input)
    {
        while (input != "END")
        {
            string[] arr = new string [input.Length];

            if ((int.Parse(input) < 10)) {
                Console.WriteLine("true");
                    }
                 
            for (int i = 0; i < input.Length - (input.Length - 1) ; i++)
            {
                for (int j = input.Length - 1 ; j > 0; j--)
                {
                    if (input[j] == input[i])
                    {
                        Console.WriteLine("true");  
                        break;
                    }  
                    else
                    {
                        Console.WriteLine("false");
                            break;
                    }
                }
            } 
            input = Console.ReadLine(); 
        }
    }
}