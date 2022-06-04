using System;
using System.Collections.Generic;

namespace P01.AdvertisementMessage
{
    class Messages
    {
        public Messages()
        {
            Phrases = new List<string>(6)
            {
                "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };
            Events = new List<string>(6)
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };
            Authors = new List<string>(8)
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            Cities = new List<string>(5)
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };
        }

        public List<string> Phrases { get; set; }
        public List<string> Events { get; set; }
        public List<string> Authors { get; set; }
        public List<string> Cities { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Messages msg = new Messages();

            Random rnd = new Random();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int indexToGet = rnd.Next(0, 6);
                string finalMessage = $"{msg.Phrases[indexToGet]} ";

                indexToGet = rnd.Next(0, 6);
                finalMessage += $"{msg.Events[indexToGet]} ";

                indexToGet = rnd.Next(0, 8);
                finalMessage += $"{msg.Authors[indexToGet]} ";

                indexToGet = rnd.Next(0, 5);
                finalMessage += $"- {msg.Cities[indexToGet]}.";

                Console.WriteLine(finalMessage);
            }
        }
    }
}
