using System;

public class Program
{
    public static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        int lastnum = n % 10; 

        if (lastnum == 0)
        {
            Console.WriteLine("zero");
        }
        if (lastnum == 1)
        {
            Console.WriteLine("one");
        }
        if (lastnum == 2)
        {
            Console.WriteLine("two");
        }
        if (lastnum == 3)
        {
            Console.WriteLine("three");
        }
        if (lastnum == 4)
        {
            Console.WriteLine("four");
        }
        if (lastnum == 5)
        {
            Console.WriteLine("five");
        }
        if (lastnum == 6)
        {
            Console.WriteLine("six");
        }
        if (lastnum == 7)
        {
            Console.WriteLine("seven");
        }
        if (lastnum == 8)
        {
            Console.WriteLine("eight");
        }
        if (lastnum == 9)
        {
            Console.WriteLine("nine");
        }

    }
}
