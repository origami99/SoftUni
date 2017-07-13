using System;
using System.Collections.Generic;
using System.Linq;

class LongestIncreasingSubsequence
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int[] len = new int[nums.Length];
        int[] prev = new int[nums.Length];
        int bestLength = 0;
        int lastIndex = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            len[i] = 1;
            prev[i] = -1;

            for (int j = 0; j < i; j++)
            {
                if (nums[j] < nums[i] && len[j] >= len[i])
                {
                    len[i] = 1 + len[j];
                    prev[i] = j;
                }
            }

            if (len[i] > bestLength)
            {
                bestLength = len[i];
                lastIndex = i;
            }
        }

        List<int> longestSeq = new List<int>();
        for (int i = 0; i < bestLength; i++)
        {
            longestSeq.Add(nums[lastIndex]);
            lastIndex = prev[lastIndex];
        }

        longestSeq.Reverse();

        Console.WriteLine(string.Join(" ", longestSeq));
    }
}
