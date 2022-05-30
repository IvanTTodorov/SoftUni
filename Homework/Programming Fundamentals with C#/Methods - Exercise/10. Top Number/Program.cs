using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        IsNumberTop(number);    

    }
    static void IsNumberTop(int number)
    {
        for (int i = 1; i < number; i++)
        {
            if (DivisibleBy8(i) && (ContainOddNumbers(i)))
            {
                Console.WriteLine(i);
            }
        }
    }
    static bool DivisibleBy8(int number)
    {
        int digitSum = 0;
        while (number > 0)
        {
            digitSum += number % 10;
            number /= 10;

        }
        if (digitSum % 8 == 0)
        {
            return true;
        }
        return false;
    }
    static bool ContainOddNumbers(int number)
    {

        while (number > 0)
        {
            if (number % 10 % 2 == 1)
            {
                return true;
            }
            number /= 10; 
        }
        return false;
    }
}
