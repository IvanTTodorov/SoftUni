using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Action<IEnumerable<int>> action = x => Console.WriteLine(String.Join(" ", x));

        string text = Console.ReadLine();
        List<int> currentNumbers = new List<int>();
        Predicate<int> isEven = x => x % 2 == 0;

        for (int i = numbers[0]; i <= numbers[1]; i++)
        {
            currentNumbers.Add(i);
        }

        if (text == "even")
        {
            action(currentNumbers.Where(x => isEven(x)));
        }
        else
        {
            action(currentNumbers.Where(x => !isEven(x)));
        }
    }
}



