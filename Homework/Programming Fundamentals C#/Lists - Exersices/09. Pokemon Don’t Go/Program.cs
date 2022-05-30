using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
       
        List<int> arr  = new List<int>();

        int count = 0;

        while (list.Count > 0)
        {
            int index = int.Parse(Console.ReadLine());


            for (int i = count; i < count + 1; i++)
            {
                if (index < 0)
                {
                    arr.Add(list[0]);
                    list.RemoveAt(0);
                    list.Insert(0, list[list.Count - 1]);
                    break;
                }
                else if (index > list.Count - 1)
                {
                    arr.Add(list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                    list.Add(list[0]);
                    
                    
                    break;
                }
                else
                {
                    arr.Add(list[index]);
                    list.RemoveAt(index);
                    break;

                }  
            }
            

            for (int i = 0 ; i < list.Count; i++)
            {
                if (arr[count] >= list[i])
                {
                    list[i] += arr[count];
                }
                else
                {
                    list[i] -= arr[count];
                }
            }
            count++;


            
        }

        int sum = arr.Sum();

        Console.WriteLine(sum);
    }
}
