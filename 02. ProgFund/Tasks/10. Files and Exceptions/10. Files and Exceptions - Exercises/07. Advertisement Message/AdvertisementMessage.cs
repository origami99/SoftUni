using System;
using System.Collections.Generic;

class AdvertisementMessage
{
    static void Main()
    {
        Dictionary<string, string[]> adData = new Dictionary<string, string[]>
        {
            {
                "Phrases", new string[]
                {
                    "Excellent product.",
                    "Such a great product.",
                    "I always use that product.",
                    "Best product of its category.",
                    "Exceptional product.",
                    "I can’t live without this product."
                }
            },
            {
                "Events", new string[]
                {
                    "Now I feel good.",
                    "I have succeeded with this product.",
                    "Makes miracles. I am happy of the results!",
                    "I cannot believe but now I feel awesome.",
                    "Try it yourself, I am very satisfied.",
                    "I feel great!"
                }
            },
                        {
                "Authors", new string[]
                {
                    "Diana",
                    "Petya",
                    "Stella",
                    "Elena",
                    "Katya",
                    "Iva",
                    "Annie",
                    "Eva"
                }
            },
            {
                "Cities", new string[]
                {
                    "Burgas",
                    "Sofia",
                    "Plovdiv",
                    "Varna",
                    "Ruse"
                }
            }
        };

        int n = int.Parse(Console.ReadLine());
        Random rnd = new Random();

        for (int i = 0; i < n; i++)
        {
            int rndPhraseIndex = rnd.Next(0, adData["Phrases"].Length);
            int rndEventIndex = rnd.Next(0, adData["Events"].Length);
            int rndAuthorIndex = rnd.Next(0, adData["Authors"].Length);
            int rndCityIndex = rnd.Next(0, adData["Cities"].Length);

            string rndPhrase = adData["Phrases"][rndPhraseIndex];
            string rndEvent = adData["Events"][rndEventIndex];
            string rndAuthor = adData["Authors"][rndAuthorIndex];
            string rndCity = adData["Cities"][rndCityIndex];

            Console.WriteLine($"{rndPhrase} {rndEvent} {rndAuthor} - {rndCity}");
        }
    }
}
