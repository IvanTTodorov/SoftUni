using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
namespace GenericBoxofInt
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box box = new Box();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                box.Add(input);
            }
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            box.Swap(nums[0], nums[1]); 
            Console.WriteLine(box.ToString());
        }
    }
}