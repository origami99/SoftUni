using System;
using System.Collections.Generic;
using System.Linq;

class MaxSequenceOfEqualElements
{
    /// <summary>
    /// Do not use this algorithm in real software - it's slow.
    /// </summary>
    static void Main()
    {
        string[] nums = Console.ReadLine().Split();

        string[] bestPart = new string[0];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 1; j <= nums.Length - i; j++)
            {
                string[] subArray = nums.Skip(i).Take(j).ToArray();

                if (subArray.All(x => x == subArray[0])
                    && subArray.Length > bestPart.Length)
                {
                    bestPart = subArray;
                }
            }
        }

        Console.WriteLine(string.Join(" ", bestPart));
    }
}
