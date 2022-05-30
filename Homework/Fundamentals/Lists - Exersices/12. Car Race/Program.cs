using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)

    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int finishLine = numbers.Length / 2 + 1;
        double sumFirstCar = 0;
        double sumSecondCar = 0;
        for (int i = 0; i < finishLine - 1; i++)
        {
            sumFirstCar += numbers[i];
            if (numbers[i] == 0)
            {
                sumFirstCar = sumFirstCar * 0.80;
            }
        }
        for (int i = finishLine; i < numbers.Length; i++)
        {
            sumSecondCar += numbers[i];
            if (numbers[i] == 0)
            {
                sumSecondCar = sumSecondCar * 0.80;
            }

        }
        if (sumFirstCar > sumSecondCar)
        {
            Console.WriteLine($"The winner is right with total time: {sumSecondCar}");
        }
        else if (sumSecondCar > sumFirstCar)
        {
            Console.WriteLine($"The winner is left with total time: {sumFirstCar}");
        }



    }
}