
using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());
        int totalSum = 0;
        int[] arrSum = new int[n];



        for (int i = 0; i < n; i++)
        {
            string text = Console.ReadLine();




            for (int j = 0; j < text.Length; j++)
            {

                if (text[j] == 97 || text[j] == 101 || text[j] == 105 ||
                    text[j] == 111 || text[j] == 117 || text[j] == 65 ||
                    text[j] == 69 || text[j] == 73 || text[j] == 79 ||
                    text[j] == 85)
                {
                    totalSum += text.Length * text[j];
                }
                else
                {
                    totalSum += text[j] / text.Length;
                }

            }
            arrSum[i] = totalSum;

            totalSum = 0;
        }
        Array.Sort(arrSum);
        for (int i = 0; i < arrSum.Length; i++)
        {
            Console.WriteLine(arrSum[i]);
        }

    }
}
