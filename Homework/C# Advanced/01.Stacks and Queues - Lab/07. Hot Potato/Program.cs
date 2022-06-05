using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        string[] children = Console.ReadLine().Split(); 
        Queue <string> names = new Queue <string>(children);
        int n = int.Parse(Console.ReadLine());
        

        while (names.Count > 1)
        {
            for (int i = 1; i <= n - 1; i++)
            {
                string player = names.Dequeue();
                names.Enqueue(player);
            }
            string lostPlayer = names.Dequeue();
            Console.WriteLine($"Removed {lostPlayer}");
        }
        string lastPlayer = names.Dequeue();
        Console.WriteLine($"Last is {lastPlayer}");
                
        }
    }

