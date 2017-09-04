using System;

class AdvertisementMessage
{
    static void Main()
    {
        string[] phrases = Phrases();
        string[] events = Events();
        string[] authors = Authors();
        string[] cities = Cities();

        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int phrasesRndIndex = rnd.Next(0, phrases.Length);
            int eventsRndIndex = rnd.Next(0, events.Length);
            int authorRndIndex = rnd.Next(0, authors.Length);
            int citiesRndIndex = rnd.Next(0, cities.Length);

            Console.Write($"{phrases[phrasesRndIndex]} ");
            Console.Write($"{events[eventsRndIndex]} ");
            Console.Write($"{authors[authorRndIndex]} - ");
            Console.WriteLine($"{cities[citiesRndIndex]}");
        }
    }

    static string[] Phrases()
    {
        string[] phrases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        return phrases;
    }

    static string[] Events()
    {
        string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        return events;
    }

    static string[] Authors()
    {
        string[] authors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "katya",
            "Iva",
            "Annie",
            "Eva"
        };

        return authors;
    }

    static string[] Cities()
    {
        string[] cities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        return cities;
    }
}
