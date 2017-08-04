using System;
using System.Linq;

class OddFilter
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums.Average())
            {
                nums[i]++;
            }
            else
            {
                nums[i]--;
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}
