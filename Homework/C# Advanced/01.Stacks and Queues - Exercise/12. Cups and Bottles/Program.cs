using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
class Program
{
    static void Main(string[] args)
    {
        int[] cup = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] bottle = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Queue<int> cups = new Queue<int>(cup);
        Stack<int> bottles = new Stack<int>(bottle);

        int wastedWater = 0;
        while (cups.Count > 0 && bottles.Count > 0)
        {

            int currentCup = cups.Dequeue();
            int currentBottle = bottles.Pop();

            if (currentCup <= currentBottle)
            {
                wastedWater += currentBottle - currentCup;

            }
            else if (currentCup > currentBottle)
            {
                while (currentCup >= 0)
                {
                    if (currentCup > currentBottle)
                    {
                        currentCup -= currentBottle;
                        currentBottle = bottles.Pop();
                    }
                    else if (currentCup < currentBottle)
                    {
                        wastedWater += currentBottle - currentCup;
                        currentCup -= currentBottle;

                    }
                    else if (currentCup == currentBottle)
                    {
                        currentBottle = bottles.Pop();
                        currentCup = cups.Dequeue();
                    }
                    if (cups.Count == 0 || bottles.Count == 0)
                    {
                        if (currentBottle > currentCup)
                        {
                            wastedWater += currentBottle - currentCup;
                        }
                        break;
                    }
                }


            }
        }
        if (bottles.Count > cups.Count)
        {
            Console.WriteLine($"Bottles: {String.Join(" ", bottles)}");

        }
        else if (cups.Count > bottles.Count)
        {
            Console.WriteLine($"Cups: {String.Join(" ", cups)}");
        }
        Console.WriteLine($"Wasted litters of water: {wastedWater}");

    }

}





