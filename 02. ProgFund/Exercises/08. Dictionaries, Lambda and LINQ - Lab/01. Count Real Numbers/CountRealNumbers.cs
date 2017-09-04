using System;
using System.Collections.Generic;
using System.Linq;

class CountRealNumbers
{
    static void Main()
    {
        double[] nums = Console.ReadLine()
            .Split(' ')
            .Select(x => double.Parse(x))
            .ToArray();

        SortedDictionary<double, int> globalCounter = new SortedDictionary<double, int>();

        foreach (double num in nums)
        {
            if (globalCounter.ContainsKey(num))
            {
                globalCounter[num]++;
            }
            else
            {
                globalCounter[num] = 1;
            }
        }

        foreach (var num in globalCounter)
        {
            Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}
