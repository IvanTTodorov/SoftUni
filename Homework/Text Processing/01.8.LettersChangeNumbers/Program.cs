using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LettersChangeNumbers
{
    class Program
    {
        public static object Utils { get; private set; }

        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal  result = 0;

            foreach (var item in input)
            {
                char firstLetter = item[0];
                char lastLetter = item[item.Length - 1];
                decimal number = decimal.Parse(item.Substring(1, item.Length - 2).ToString());

                decimal firstLetterPosition = char.Parse(firstLetter.ToString().ToUpper()) - 64;
                decimal lastLetterPosition = char.Parse(lastLetter.ToString().ToUpper()) - 64;
                decimal firstResult = FirstLetterOperations(firstLetter, number, firstLetterPosition);
                decimal secondResult = SecondLetterOperation(lastLetter, number, lastLetterPosition, firstResult);
                result += secondResult;

            }
            Console.WriteLine($"{result:f2}");
        }  
        public static decimal FirstLetterOperations(char firstLetter, decimal number, decimal firstLetterPosition)
        {
            decimal result = 0;
            if (firstLetter >= 65 && firstLetter <= 90)
            {
                result = number / firstLetterPosition;

            }
            else
            {
                result = number * firstLetterPosition;
            }
            return result;
        }
        public static decimal SecondLetterOperation(char secondLetter, decimal number, decimal secondLetterPosition,
            decimal firstResult)

        {
            if (secondLetter >= 65 && secondLetter <= 90)
            {
                firstResult = firstResult - secondLetterPosition;

            }
            else
            {
                firstResult = firstResult + secondLetterPosition;
            }
            return firstResult;
        }

        
    }
}