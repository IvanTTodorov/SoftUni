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
        int foodSum = int.Parse(Console.ReadLine());
        int[] orders = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Queue<int> numbers = new Queue<int>(orders);
        Console.WriteLine(numbers.Max()); 

        for (int i = 0; i < orders.Length; i++)
        {
            if (foodSum >= numbers.Peek())
            {
                foodSum -= numbers.Peek();
                numbers.Dequeue();
            }
            else
            {
                Console.WriteLine($"Orders left: {String.Join(" ", numbers)}");
                break;
            }
        }
        if (numbers.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        
    }
}
