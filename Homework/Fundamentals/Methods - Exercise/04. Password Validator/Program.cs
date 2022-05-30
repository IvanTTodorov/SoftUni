using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        PasswordValidator(input);

    }
    static void PasswordValidator (string input)
    {
        bool invalid = true; 
        if (input.Length < 6 || input.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
            invalid = false;
        }
        if (CheckIfThereAreDigitsAndLetters(input) == false)
        {
            Console.WriteLine("Password must consist only of letters and digits");
            invalid = false;
        }
        if (ContiainAtLeast2Digits(input) < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
            invalid = false;
        }
        if (invalid == true)
        {
            Console.WriteLine("Password is valid");
        }
        


    }
    static bool CheckIfThereAreDigitsAndLetters (string input)
    {

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
            if (!((currentChar >= 48 && currentChar <= 57) ||
                (currentChar >= 65 && currentChar <= 90) ||
                (currentChar >= 97 && currentChar <= 122))) 
            {
                return false;
            }
        }
        return true;
    }
    static int ContiainAtLeast2Digits (string input)
    {
        int digitsCounter = 0;
        
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i]; 
            if (currentChar >= 48 && currentChar <= 57)
            {
                digitsCounter++; 
            }
            

        } return digitsCounter;
    }
}