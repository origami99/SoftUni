using System;
using System.Collections.Generic;
using System.Linq;

class BombNumbers
{
    static void Main()
    {
        List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
        string[] specialNums = Console.ReadLine().Split();

        int bomb = int.Parse(specialNums[0]);
        int power = int.Parse(specialNums[1]);

        for (int i = 0; i < nums.Count; i++)
        {
            if (nums[i] == bomb)
            {
                int left = Math.Max(i - power, 0);
                int right = Math.Min(i + power, nums.Count - 1);

                int length = right - left + 1;
                nums.RemoveRange(left, length);
                i = 0;
            }
        }

        Console.WriteLine(nums.Sum());
    }
}