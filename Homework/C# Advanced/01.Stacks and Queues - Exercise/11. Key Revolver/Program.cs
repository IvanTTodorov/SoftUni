using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int sizeOfGunBarell = int.Parse(Console.ReadLine());
        int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int valueOfIntelligence = int.Parse(Console.ReadLine());
        int count = 0;
        int totalBullets = 0;

        Queue<int> queueLocks = new Queue<int>(locks);
        Stack<int> stackBullets = new Stack<int>(bullets);

        while (true)
        {

            int currentBullet = stackBullets.Pop();
            int currentLocks = queueLocks.Peek();
            if (currentBullet <= currentLocks)
            {
                Console.WriteLine("Bang!");
                queueLocks.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }
            totalBullets++;
            count++;

            if (count == sizeOfGunBarell && stackBullets.Count != 0)
            {
                Console.WriteLine("Reloading!");
                count = 0;
            }
            if (queueLocks.Count == 0)
            {
                int earnedMoney = valueOfIntelligence - (totalBullets * bulletPrice);
                int bulletsLeft = stackBullets.Count;
                Console.WriteLine($"{bulletsLeft} bullets left. Earned ${earnedMoney}");
                return;
            }
            if (stackBullets.Count == 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {queueLocks.Count}");
                return;
            }

        }

    }

}



