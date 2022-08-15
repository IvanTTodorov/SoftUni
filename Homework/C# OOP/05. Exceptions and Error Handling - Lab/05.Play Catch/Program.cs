using System;
using System.Collections.Generic;
using System.Linq;

namespace PlayCatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int count = 0;

            while (count < 3)
            {
                string[] command = Console.ReadLine().Split();
                string action = command[0]; 

                try
                {
                    if (action == "Replace")
                    {
                        int a = int.Parse(command[1]);
                        int b = int.Parse(command[2]);
                        Replace(a, b, list);
                    }
                    else if (action == "Print")
                    {
                        int startIndex = int.Parse(command[1]);
                        int endIndex = int.Parse(command[2]);
                        Console.WriteLine(string.Join(", ", Print(startIndex, endIndex, list)));
                    }
                    else if (action == "Show")
                    {
                        int index = int.Parse(command[1]);
                        Console.WriteLine(Show(index, list));
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The index does not exist!");
                    count++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    count++;
                }
            }
            Console.WriteLine(String.Join(", ",list));
        }

        private static int Show(int index, List<int> list)
        {
            return list[index];
        }

        private static List<int> Print(int startIndex, int endIndex, List<int> list)
        {
            return list.GetRange(startIndex, endIndex - startIndex + 1);
        }

        private static void Replace(int a, int b, List<int> arr)
        {
            
            arr.RemoveAt(a);
            arr.Insert(a, b);
        }
    }
}
