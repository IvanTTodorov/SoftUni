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
            if (second > third)
            {
                Console.WriteLine(first);
                Console.WriteLine(second);
                Console.WriteLine(third);
            } 
            else
            {
                Console.WriteLine(first);
                Console.WriteLine(third);
                Console.WriteLine(second);

            }
            }
        if (second > first && second > third)
        {
            if (first > third)
            {
                Console.WriteLine(second);
                Console.WriteLine(first);
                Console.WriteLine(third);
            }
            else
            {
                Console.WriteLine(second);
                Console.WriteLine(third);
                Console.WriteLine(first);

            }
        }
        if (third > second && third > first)
        {
            if (second > first)
            {
                Console.WriteLine(third);
                Console.WriteLine(second);
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(third);
                Console.WriteLine(first);
                Console.WriteLine(second);

            }
        }
    }  



    }