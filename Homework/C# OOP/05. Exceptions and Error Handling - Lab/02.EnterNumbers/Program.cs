using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            int start = 1;
           

            while (true)
            {
                try
                { 
                    if(nums.Count == 10)
                    {
                        break;
                    }
                    int n = int.Parse(Console.ReadLine());
                    ReadNumber(start, 100, n, nums);
                    start++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine($"Your number is not in range {start} - 100!");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
            }
            Console.WriteLine(String.Join(", ", nums));

        }


        public static void ReadNumber(int start, int end, int n, List<int> nums)
        {
            if (n > end || n <= start)
            {
                throw new ArgumentOutOfRangeException();
            }
            nums.Add(n);
        }
    }
}
