using System;

public class Program
{
    public static void Main(string[] args)
    {

        var first = int.Parse(Console.ReadLine());
        var second = int.Parse(Console.ReadLine()); 
        var third = int.Parse(Console.ReadLine());

        if (first > second && first > third)
        {
            Console.WriteLine(first);
            if (second > third)
            {
                Console.WriteLine(second);
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine(third);
                Console.WriteLine(second);
            }
        }
        else if (second > first && second > third)
        {
            Console.WriteLine(second);
            if (first > third)
            {
                Console.WriteLine(first);
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine(third);
                Console.WriteLine(first);
            }
        }

        else if (third > first && third > second)
        {
            Console.WriteLine(third);
            if (first > second)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
            }
            else
            {
                Console.WriteLine(second);
                Console.WriteLine(first);
            }
        }
    }
}
