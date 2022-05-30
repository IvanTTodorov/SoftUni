using System;

class Program
{
    static void Main(string[] args)

    {
        int pokePower = int.Parse(Console.ReadLine());
        int distance = int.Parse(Console.ReadLine());
        byte exhaustionFactor = byte.Parse(Console.ReadLine());

        int count = 0;
        double originalPower = pokePower * 0.5;

        while (pokePower >= distance)
        {
            pokePower -= distance;
            count++;
            if (pokePower == (originalPower) && exhaustionFactor > 0)
            {
                pokePower /= exhaustionFactor;

                if (pokePower < distance)
                {
                    break;
                }
            }
            
        }
            Console.WriteLine(pokePower);
            Console.WriteLine(count);
        }
    }
