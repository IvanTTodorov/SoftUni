using System;

class Program
{
    static void Main(string[] args)

        {
            int startNumber = int.Parse(Console.ReadLine());
            int stopNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= stopNumber; i++)
            {
                Console.Write((char)i + " ");

            }
        }
    }

