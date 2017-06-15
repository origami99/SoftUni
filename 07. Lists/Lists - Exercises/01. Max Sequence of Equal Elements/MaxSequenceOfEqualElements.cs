using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        int currLength = 0;
        int? currStart = null;
        int? prevNum = null;
        int? bestStart = null;
        int bestLength = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == prevNum)
            {
                if (currLength == 0)
                {
                    currStart = i;
                }

                currLength++;

                if (currLength > bestLength)
                {
                    bestLength = currLength;
                    bestStart = currStart;
                }
            }
            else
            {
                currLength = 0;
            }

            prevNum = nums[i];
        }

        for (int i = 0; i <= bestLength; i++)
        {
            Console.Write(nums[(int)bestStart] + " ");
        }
        Console.WriteLine();
    }
}
