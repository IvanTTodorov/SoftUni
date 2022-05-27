using System;

namespace _2.PascalTriangleMy
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine(1);

            if (row == 1)
            {
                return;
            }


            int[] beforArr = new int[] { 1, 1 };

            Console.WriteLine(string.Join(" ", beforArr));
            if (row == 2)
            {
                return;
            }

            for (int i = 3; i <= row; i++)
            {
                int[] nextArr = new int[beforArr.Length + 1];

                for (int j = 1; j < nextArr.Length - 1; j++)
                {
                    nextArr[0] = 1;
                    nextArr[nextArr.Length - 1] = 1;

                    nextArr[j] = beforArr[j - 1] + beforArr[j];
                }
                Console.WriteLine(string.Join(" ", nextArr));
                beforArr = nextArr;
            }
        }
    }
}