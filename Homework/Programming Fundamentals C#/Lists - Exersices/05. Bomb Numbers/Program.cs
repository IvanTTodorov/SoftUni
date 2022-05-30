using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        int[] bombData = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int bomb = bombData[0];
        int power = bombData[1];

        int bombIndex = list.IndexOf(bomb);
        
        while (bombIndex != -1)
        {
            int leftIndex = bombIndex - power;
            int rightIndex = bombIndex + power;
            if (leftIndex < 0)
            {
                leftIndex = 0;
            }
            if (rightIndex > list.Count - 1)
            {
                rightIndex = list.Count - 1;
            }
            list.RemoveRange(leftIndex, rightIndex - leftIndex + 1);

            bombIndex = list.IndexOf(bomb);
        }
        int sum = 0; 
        foreach (var item in list)
        {
            sum += item;
        }
        Console.WriteLine(sum);


    }
}