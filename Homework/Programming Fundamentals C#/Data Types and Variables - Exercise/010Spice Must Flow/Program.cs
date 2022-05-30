using System;

class Program
{
    static void Main(string[] args)

    {
        int startingYeld = int.Parse(Console.ReadLine());

        int produced = 0;
        int days = 0;

        if (startingYeld < 100)
        {
            Console.WriteLine(days);
            Console.WriteLine(produced);
        }
        else
        {
            while (startingYeld >= 100)
            {
                produced += startingYeld - 26;
                startingYeld -= 10;
                days++;
            }

            produced -= 26;

            Console.WriteLine(days);
            Console.WriteLine(produced);
        }
    }
}
