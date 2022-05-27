using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());
        Console.WriteLine(SubstractNumbers(first, second, third)); 
    }
    static int AddNumbers (int first, int second)
    {
        int result = first + second;
        return result;
    }
    static int SubstractNumbers ( int first, int second, int third)
    {
        int substracted = (first + second) - third;
        return substracted; 
    }
}