using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        string input;

        while ((input = Console.ReadLine()) != "End")
        {
            string[] text = input.Split();
            if (text[0] == "Add")
            {
                list.Add(int.Parse(text[1]));
            }
            else if (text[0] == "Insert")
            {
                if(int.Parse(text[2]) >= 0 && int.Parse(text[2]) < list.Count)
                {
                    list.Insert(int.Parse(text[2]), int.Parse(text[1]));
                } else
                {
                    Console.WriteLine("Invalid index");
                }
                    
            }
            else if (text[0] == "Remove")
            {
                if (int.Parse(text[1]) >= 0 && int.Parse(text[1]) < list.Count)
                {
                    list.RemoveAt(int.Parse(text[1]));
                }
                else
                {
                    Console.WriteLine("Invalid index");
                }
            }
            else if (text[0] == "Shift" && text[1] == "left")
            {
                int count = int.Parse(text[2]);
                for (int i = 0; i < count; i++)
                {
                    list.Add(list[0]);
                    list.Remove(list[0]);
                }
            }
            else if (text[0] == "Shift" && text[1] == "right")
            {
                int count = int.Parse(text[2]);
                for (int i = 0; i < count; i++)
                {
                    list.Insert(0, list[list.Count - 1]);
                    list.RemoveAt(list.Count - 1);
                }
            }

        }
        Console.WriteLine(String.Join(" ", list));
    }
}