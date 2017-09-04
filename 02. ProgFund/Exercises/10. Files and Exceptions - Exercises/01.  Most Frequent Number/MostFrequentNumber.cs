using System;
using System.Collections.Generic;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();

        Dictionary<string, int> counts = nums
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => x.Count());

        int maxValue = counts.Values.Max();
        string mostFreqNum = counts.First(x => x.Value == maxValue).Key;

        Console.WriteLine(mostFreqNum);
    }
}
