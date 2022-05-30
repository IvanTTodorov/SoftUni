using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        int n = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        int bestIndex = 0;
        int bestSequanceSum = 0;
        int bestSequanceLength = 1;
        int bestSequanceIndex = 0;

        int[] bestSequance = new int[n];
        int sequanceCounter = 0; 

        while (input != ("Clone them!"))
        {
            int[] numbers = input
               .Split('!', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

            sequanceCounter++;

            int long1 = 1;
            int longest = 0;

            int sum = 0;
            int maxSum = 0;

            int index = 0;
            


            for (int i = 0; i < numbers.Length - 1; i++)
            {
                

                if (numbers[i] == numbers[i+1])
                    {
                        long1++;
                    }
                    else
                    {
                        long1 = 1;
                      
                    }
                    if (long1 > longest)
                    {
                        longest = long1;
                        index = i;
                }
                sum += numbers[i]; 
                }
            sum += numbers[numbers.Length - 1];


                if (longest > bestSequanceLength)
                {
                bestSequanceLength = longest;
                bestIndex = index;
                bestSequanceSum = sum;
                bestSequanceIndex = sequanceCounter;
                bestSequance = numbers.ToArray();

                }
                else if (longest == bestSequanceLength)
            {
                if ( index < bestIndex)
                {
                    bestSequanceLength = longest;
                    bestIndex = index;
                    bestSequanceSum = sum;
                    bestSequanceIndex = sequanceCounter;
                    bestSequance = numbers.ToArray();

                } else if ( index == bestIndex)
                {
                    if ( sum > bestSequanceSum)
                    {
                        bestSequanceLength = longest;
                        bestIndex = index;
                        bestSequanceSum = sum;
                        bestSequanceIndex = sequanceCounter;
                        bestSequance = numbers.ToArray();
                    }
                }
            }
            input = Console.ReadLine();
        }
        Console.WriteLine($"Best DNA sample {bestSequanceIndex} with sum: {bestSequanceSum}.");
        Console.WriteLine(String.Join(" ", bestSequance));
    }

       
       
    }
