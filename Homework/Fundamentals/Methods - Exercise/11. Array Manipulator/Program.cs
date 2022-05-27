using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
    int [] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        string input = String.Empty; 
        while ((input = Console.ReadLine()) != "end") {

            string[] command = input.Split(); 

            if (command[0] == "exchange")
            {

            }

        }
    }
    static void Exchange (int [] array, int index)
    {
        int [] array1 = new int [array.Length - index - 1];
        int[] array2 = new int[index + 1];

        int firstArrayCounter = 0; 
        for (int i = index + 1; i < array.Length; i++)
        {
            array1[firstArrayCounter] = array[i];
            firstArrayCounter++; 
        }
        for (int i = 0; i < index + 1; i++)
        {
            array1[i] = array[i];
        }

    }
}