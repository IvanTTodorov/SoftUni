using System;
using System.Linq;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split();
            int total = 0;
            int count = -1;

            while (count < arr.Length - 1)
            {
                try
                {
                    count++;
                    int num = MyParse(arr[count]);
                    total += num;

                    
                }
                catch (FormatException)
                {
                    Console.WriteLine($"The element '{arr[count]}' is in wrong format!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"The element '{arr[count]}' is out of range!");
                }  
             

                Console.WriteLine($"Element '{arr[count]}' processed - current sum: {total}");
            }
            Console.WriteLine($"The total sum of all integers is: {total}");

        }

        private static int MyParse(string v)
        {
            return int.Parse(v);
        }
    }
}