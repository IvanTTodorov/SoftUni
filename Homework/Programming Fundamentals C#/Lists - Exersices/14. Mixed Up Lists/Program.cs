
using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        List<int> numbers1 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
        List<int> newNumbers = new List<int>();
        List<int> last2Digits = new List<int>();
        List<int> print = new List<int>();


        if (numbers1.Count > numbers2.Count)
        {
            numbers2.Reverse();
            for (int i = 0; i < numbers1.Count - 2; i++)
            {
                newNumbers.Add(numbers1[i]);
                newNumbers.Add(numbers2[i]);
            }
            last2Digits.Add(numbers1[numbers1.Count - 2]);
            last2Digits.Add(numbers1[numbers1.Count - 1]);
            last2Digits.Sort();
        }
        else if (numbers2.Count > numbers1.Count)
        {
            numbers2.Reverse();
            for (int i = 0; i < numbers2.Count - 2; i++)
            {
                newNumbers.Add(numbers2[i]);
                newNumbers.Add(numbers1[i]);
            }
            last2Digits.Add(numbers2[numbers2.Count - 2]);
            last2Digits.Add(numbers2[numbers2.Count - 1]);
            last2Digits.Sort();
        }

        for (int i = 0; i < newNumbers.Count; i++)
        {
            if (newNumbers[i] > last2Digits[0] && newNumbers[i] < last2Digits[1])
            {
                print.Add(newNumbers[i]);
            }
            print.Sort();
        }

        Console.WriteLine(String.Join(' ', print));
    }
}