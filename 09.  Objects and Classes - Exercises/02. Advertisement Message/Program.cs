using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            string[] authors = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            string[] cities = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
            int numberOfMessages = int.Parse(Console.ReadLine());
            Random phraseIndex = new Random();
            Random eventsIndex = new Random();
            Random authorsIndex = new Random();
            Random citiesIndex = new Random();
            phraseIndex.Next(0, phrases.Length);
            eventsIndex.Next(0 ,events.Length);
            authorsIndex.Next(0, events.Length);
            citiesIndex.Next(0, cities.Length);
            for (int i = 0; i < numberOfMessages; i++)
            {
            Console.WriteLine("{0} {1} {2} – {3}" , phrases[phraseIndex.Next(0, phrases.Length)], events[eventsIndex.Next(0, events.Length)], authors[authorsIndex.Next(0, events.Length)], cities[citiesIndex.Next(0, cities.Length)]);
            }
           
        }
    }
}
