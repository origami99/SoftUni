using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class WordCount
{
    static void Main()
    {
        string[] words = File.ReadAllText("words.txt")
            .ToLower()
            .Split();
        string[] text = File.ReadAllText("input.txt")
            .ToLower()
            .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' },
            StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> wordCounts = new Dictionary<string, int>();

        foreach (string w in words)
        {
            wordCounts[w] = 0;
        }

        foreach (string word in text)
        {
            if (wordCounts.ContainsKey(word))
            {
                wordCounts[word]++;
            }
        }

        wordCounts = wordCounts
            .OrderByDescending(x => x.Value)
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (var word in wordCounts)
        {
            Console.WriteLine($"{word.Key} -> {word.Value}");
        }
    }
}
