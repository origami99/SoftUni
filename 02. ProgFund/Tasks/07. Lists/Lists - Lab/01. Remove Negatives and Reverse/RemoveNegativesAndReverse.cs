using System;
using System.Linq;
using System.Collections.Generic;

class RemoveNegativesAndReverse
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        List<int> positiveList = new List<int>();

        foreach (var n in nums)
        {
            if (n >= 0)
            {
                positiveList.Add(n);
            }
        }

        positiveList.Reverse();

        if (positiveList.Count != 0)
        {
            Console.WriteLine(string.Join(" ", positiveList));
        }
        else
        {
            Console.WriteLine("empty");
        }
    }
}
