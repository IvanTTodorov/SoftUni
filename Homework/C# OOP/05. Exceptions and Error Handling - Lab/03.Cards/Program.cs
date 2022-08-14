using System;
using System.Collections.Generic;

namespace Cards
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] face = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<Card> allCard = new List<Card>();
            int i = 0;

            while (i < face.Length)
            {
                try
                {
                    string[] cardInfo = face[i].Split();
                    i++;
                    CreateCard(cardInfo[0], cardInfo[1]);
                    Card card = new Card(cardInfo[0], cardInfo[1]);
                    allCard.Add(card);
                    

                }

                catch (ArgumentException)
                {
                    Console.WriteLine("Invalid card!");
                }
            }

            foreach (var item in allCard)
            {
                Console.Write(item.ToString() + " ");
            }
        }
        public static void CreateCard(string face, string suit)
        {
            if (face != "1" && face != "2" && face != "3" && face != "4" && face != "5"
                && face != "6" && face != "7" && face != "8" && face != "9" && face != "10"
                && face != "J" && face != "Q" && face != "K" && face != "A")
            {
                throw new ArgumentException();
            }
            if (suit != "S" && suit != "H" && suit != "D" && suit != "C")
            {
                throw new ArgumentException();
            }
        }
    }

    public class Card
    {
        private string face;
        private string suit;

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face
        {
            get { return face; }
            set { face = value; }
        }
        public string Suit
        {
            get { return suit; }
            set { suit = value; }
        }

        public override string ToString()
        {
            if (Suit == "S")
            {
                return $"[{Face}\u2660]";
            }
            else if (Suit == "H")
            {
                return $"[{Face}\u2665]";
            }
            else if (Suit == "D")
            {
                return $"[{Face}\u2666]";
            }
            else
            {
                return $"[{Face}\u2663]";
            }

        }

    }
}









