using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double result = (FactorialFirst(num1, num2) / (FactorialSecond(num1, num2)));
        Console.WriteLine($"{result:f2}");
    }
    static double FactorialFirst (double num1, double num2)
    {
        double result1 = 1;
        for ( int i = 1; i <= num1; i++ )
        {
            result1 *= i; 
        }
        return result1;
    }
    static double FactorialSecond (double num1, double num2)
    {
        double result2 = 1; 
        for (int i = 1; i <= num2; i++)
        {
            result2 *= i; 
        }
        return result2; 
    }
}