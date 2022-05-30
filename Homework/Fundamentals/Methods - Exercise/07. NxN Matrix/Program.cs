using System;
using System.Globalization;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        Rows(number);
    }
    static void Rows(int number)
    {

        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        




    }
}
