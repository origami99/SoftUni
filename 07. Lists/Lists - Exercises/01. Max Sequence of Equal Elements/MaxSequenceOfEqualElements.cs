using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        int length = 0;
        int start = 0;
        int bestLength = 0;
        int bestStart = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            if (i != nums.Count - 1)
            {
                if (nums[i] == nums[i + 1])
                {
                    if (length == 0)
                    {
                        start = i;
                    }

                    length++;
                }
                else
                {
                    length = 0;
                }
            }

            if (length > bestLength)
            {
                bestLength = length;
                bestStart = start;
            }
        }

        for (int i = bestStart; i <= bestStart + bestLength; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
