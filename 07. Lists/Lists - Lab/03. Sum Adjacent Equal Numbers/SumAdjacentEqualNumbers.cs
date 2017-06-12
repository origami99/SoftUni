using System;
using System.Linq;
using System.Collections.Generic;

class SumAdjacentEqualNumbers
{
    static void Main()
    {
        List<double> nums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        bool hasEqualNeighbors = false;
        do
        {
            hasEqualNeighbors = false;
            double? lastNum = null;

            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] == lastNum)
                {
                    hasEqualNeighbors = true;

                    nums.RemoveAt(i - 1);
                    i--;
                    nums[i] += nums[i];

                    break;
                }

                lastNum = nums[i];
            }
        }
        while (hasEqualNeighbors);

        Console.WriteLine(string.Join(" ", nums));
    }
}
