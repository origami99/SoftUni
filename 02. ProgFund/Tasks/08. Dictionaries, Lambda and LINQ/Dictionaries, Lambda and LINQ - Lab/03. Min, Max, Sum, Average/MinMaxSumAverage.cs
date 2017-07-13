using System;
using System.Collections.Generic;
using System.Linq;

class MinMaxSumAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < n; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        Dictionary<string, double> props = new Dictionary<string, double>
        {
            { "Sum", nums.Sum() },
            { "Min", nums.Min() },
            { "Max", nums.Max() },
            { "Average", nums.Average() }
        };

        foreach (var prop in props)
        {
            Console.WriteLine("{0} = {1}", prop.Key, prop.Value);
        }
    }
}
