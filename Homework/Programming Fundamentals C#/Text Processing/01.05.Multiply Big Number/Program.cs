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
            string bigNumber = Console.ReadLine().TrimStart('0');
            int number = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            int reminder = 0;


            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(bigNumber[i].ToString()) * number + reminder;
                reminder = 0;
                if (result > 9)
                {
                    reminder = result / 10;
                    result = result % 10;
                }
                sb.Append(result); 
            }

            if (reminder > 0)
            {
                sb.Append(reminder);
            }


            StringBuilder finalResult = new StringBuilder();
            for (int i = sb.Length - 1; i >= 0; i--)
            {
                finalResult.Append(sb[i]);
            }

            Console.WriteLine(finalResult);
        }
    }
}