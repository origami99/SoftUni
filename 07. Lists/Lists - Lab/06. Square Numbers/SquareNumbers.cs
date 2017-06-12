using System;
using System.Linq;
using System.Collections.Generic;

class SquareNumbers
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<int> exactSqrts = new List<int>();

        for (int i = 0; i < nums.Count; i++)
        {
            if (Math.Sqrt(nums[i]) == (int)Math.Sqrt(nums[i]))
            {
                exactSqrts.Add(nums[i]);
            }
        }

        exactSqrts.Sort();
        exactSqrts.Reverse();

        Console.WriteLine(string.Join(" ", exactSqrts));
    }
}
