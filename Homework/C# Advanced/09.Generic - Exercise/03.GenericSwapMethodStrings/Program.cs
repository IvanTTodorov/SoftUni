using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace GenericBoxofString
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box box = new Box();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Add(input);
            }

            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            box.Swap(numbers[0], numbers[1]); 
            Console.WriteLine(box.ToString());
        }
    }
}