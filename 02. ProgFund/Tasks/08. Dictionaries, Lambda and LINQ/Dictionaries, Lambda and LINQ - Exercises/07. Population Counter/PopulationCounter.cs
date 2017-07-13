using System;
using System.Collections.Generic;
using System.Linq;

class PopulationCounter
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split('|')
            .ToArray();

        string city = input[0];
        string country = input[1];
        long population = long.Parse(input[2]);

        Dictionary<string, Dictionary<string, long>> citiesData = new Dictionary<string, Dictionary<string, long>>();
        while (input[0] != "report")
        {
            AddsNewDataInDictionary(city, country, population, citiesData);

            input = ReadingNewData(ref city, ref country, ref population);
        }

        citiesData = OrderDictionaries(citiesData);

        PrintStatistics(citiesData);
    }

    private static void AddsNewDataInDictionary(string city, string country, long population, Dictionary<string, Dictionary<string, long>> citiesData)
    {
        if (citiesData.ContainsKey(country))
        {
            citiesData[country][city] = population;
        }
        else
        {
            citiesData[country] = new Dictionary<string, long>();
            citiesData[country][city] = population;
        }
    }

    private static string[] ReadingNewData(ref string city, ref string country, ref long population)
    {
        string[] input = Console.ReadLine()
            .Split('|')
            .ToArray();
        if (input[0] != "report")
        {
            city = input[0];
            country = input[1];
            population = long.Parse(input[2]);
        }

        return input;
    }

    private static Dictionary<string, Dictionary<string, long>> OrderDictionaries(Dictionary<string, Dictionary<string, long>> citiesData)
    {
        // Ordering countries by their total population in descending order
        citiesData = citiesData
            .OrderByDescending(x => x.Value.Values.Sum())
            .ToDictionary(x => x.Key, x => x.Value);

        // Ordering cities by their total population in descending order
        for (int i = 0; i < citiesData.Count; i++)
        {
            var item = citiesData.ElementAt(i);

            citiesData[item.Key] = citiesData[item.Key]
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }

        return citiesData;
    }

    private static void PrintStatistics(Dictionary<string, Dictionary<string, long>> citiesData)
    {
        foreach (var ctry in citiesData)
        {
            Console.Write(ctry.Key);
            Console.WriteLine($" (total population: {ctry.Value.Values.Sum()})");

            foreach (var item in ctry.Value)
            {
                Console.WriteLine($"=>{item.Key}: {item.Value}");
            }
        }
    }
}
