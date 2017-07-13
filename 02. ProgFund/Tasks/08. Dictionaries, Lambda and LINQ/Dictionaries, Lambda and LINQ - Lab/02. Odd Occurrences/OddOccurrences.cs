using System;
using System.Collections.Generic;
using System.Linq;

class OddOccurrences
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        Dictionary<string, int> wordCounter = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordCounter.ContainsKey(word)) { wordCounter[word]++; }
            else { wordCounter[word] = 1; }
        }

        //wordCounter = wordCounter
        //    .Select(x => x.Key.ToLower())
        //    .Where(x => x.Value % 2 != 0)
        //    .ToDictionary(x => x.Key, x => x.Value);

        Console.WriteLine(string.Join(", ", wordCounter.Keys));
    }
}
