using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<string> list = Console.ReadLine().Split().ToList();

        string input;
        while ((input = Console.ReadLine()) != "3:1")
        {
            string[] commandElements = input.Split();
            string command = commandElements[0];


            if (command == "merge")
            {
                int startIndex = int.Parse(commandElements[1]);
                int endIndex = int.Parse(commandElements[2]);
                string merged = String.Empty;
                if (startIndex < 0 || startIndex > list.Count - 1)
                {
                    startIndex = 0;
                }
                if (endIndex > list.Count - 1)
                {
                    endIndex = list.Count - 1;
                }
                for (int i = startIndex; i <= endIndex; i++)
                {

                    merged += list[i];
                }

                list.RemoveRange(startIndex, endIndex - startIndex + 1);
                list.Insert(startIndex, merged);
            }
            else if (command == "divide")
            {
                int index = int.Parse(commandElements[1]);
                int partititons = int.Parse(commandElements[2]);
                string word = list[index];
                List<string> divided = new List<string>();

                int stringLengthToAdd = word.Length / partititons;
                int startIndex = 0;

                for (int i = 0; i < partititons; i++)
                {
                    if (i == partititons - 1)
                    {
                        divided.Add(word.Substring(startIndex, word.Length - startIndex));
                    }
                    else
                    {

                        divided.Add(word.Substring(startIndex, stringLengthToAdd));
                    } 
                    startIndex += stringLengthToAdd;
                }
                list.RemoveAt(index);
                list.InsertRange(index, divided); 
            }
        }
        Console.WriteLine(String.Join(" ", list));
    }
}