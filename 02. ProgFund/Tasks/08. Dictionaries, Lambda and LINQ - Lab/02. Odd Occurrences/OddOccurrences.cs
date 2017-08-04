using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main()
    {
        string[] words = Console.ReadLine().ToLower().Split();

        Dictionary<string, int> wordCounter = words
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());

        wordCounter = wordCounter
            .Where(x => x.Value % 2 != 0)
            .ToDictionary(x => x.Key, x => x.Value);

        Console.WriteLine(string.Join(", ", wordCounter.Keys));
    }
}
