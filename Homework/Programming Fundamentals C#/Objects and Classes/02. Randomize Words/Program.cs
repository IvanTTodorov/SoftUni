using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomizeWords word = new RandomizeWords();
            word.Words = Console.ReadLine().Split();
            word.Randomize();
            word.Print();

        }

    }


    public class RandomizeWords
    {
        public string[] Words { get; set; }
        Random rand = new Random();
        public void Randomize()
        {
            for (int i = 0; i < Words.Length - 1; i++)
            {
                int randomPosition = rand.Next(0, Words.Length);
                string temp = Words[i];
                Words[i] = Words[randomPosition];
                Words[randomPosition] = temp;

            }
        }
        public void Print()
        {
            Console.WriteLine(String.Join(Environment.NewLine, Words));
        }
    }
}