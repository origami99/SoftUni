using System;
using System.Linq;

class CondenseArrayToNumber
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int k = 0; k < nums.Length - 1; k++)
            {
                nums[k] = nums[k] + nums[k + 1];
            }
        }

        Console.WriteLine(nums[0]);
    }
}
