using System;
using System.Globalization;
using System.Linq;
using System.Collections.Generic;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] phrases = new string[] {"Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."};

            string[] events = new string[]  { "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!" };

            string[] authors = new string[] {"Diana",
                "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(RandomMessege(phrases, events, authors, cities));
            }
            
        }
        public static string RandomMessege(string[] phrases, string[] events, string[] authors, string[] cities)
        {
            Random random = new Random();
            string currentEvents = events[random.Next(0,events.Length)];
            string currentPhrases = phrases[random.Next(0, phrases.Length)];
            string currentAuthors = authors[random.Next(0, phrases.Length)]; 
            string currentCities = cities[random.Next(0, cities.Length)];

            return $"{currentPhrases} {currentEvents} {currentAuthors} – {currentCities}.";
        }

    }
}