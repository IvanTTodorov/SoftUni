using System;
using System.Linq;

class Program
{
    static void Main(string[] args)

    {
        int fieldSize = int.Parse(Console.ReadLine());
        int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] field = new int[fieldSize];

        for (int i = 0; i < fieldSize; i++)
        {
            int currentIndex = initialIndexes[i];

            if (currentIndex >= 0 && currentIndex < fieldSize)
            {
                field[currentIndex] = 1;
            }
        }
        string command = " ";

        while ((command = Console.ReadLine()) != "end")
        {
            string[] elements = command.Split(); //0 right 1

            int ladybugIndex = int.Parse(elements[0]);
            string direction = elements[1];
            int flyLength = int.Parse(elements[2]);


            if (ladybugIndex < 0 || ladybugIndex > fieldSize - 1 || field[ladybugIndex] == 0)
            {
                continue;
            }
            field[ladybugIndex] = 0;

            if (direction == "right")
            {
                int landIndex = ladybugIndex + flyLength;

                if (landIndex > fieldSize - 1)
                {
                    continue;
                }

                if (field[landIndex] == 1)
                {

                    while (field[landIndex] == 1)
                    {
                        landIndex += flyLength;

                        if (landIndex > fieldSize - 1)
                        {
                            break;
                        }

                    }

                }
                if (landIndex >= 0 && landIndex < fieldSize - 1)
                {
                    field[landIndex] = 1;
                }
            }
            else if (direction == "left")
            {
                int landIndex = ladybugIndex - flyLength;

                if (landIndex < 0)
                {
                    continue;
                }
                if (field[landIndex] == 1)
                {

                    while (field[landIndex] == 1)
                    {
                        landIndex -= flyLength;

                        if (landIndex < 0)
                        {
                            break;
                        }
                    }
                }
                if (landIndex >= 0 && landIndex < fieldSize - 1)
                {
                    field[landIndex] = 1;
                }
            }
        } Console.WriteLine(String.Join(" ", field));
        }
    }
