using System;
using System.Linq;
using System.Collections.Generic;

class CountNumbers
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        nums.Sort();

        List<int> occurNums = new List<int>();
        List<int> occurCount = new List<int>();

        while (nums.Count > 0)
        {
            int min = nums.Min();

            int counter = 0;
            for (int j = 0; j < nums.Count; j++)
            {
                if (nums[j] == min)
                {
                    counter++;
                }
            }

            occurNums.Add(min);
            occurCount.Add(counter);

            nums.RemoveAll(x => x == min);
        }

        for (int i = 0; i < occurNums.Count; i++)
        {
            Console.WriteLine($"{occurNums[i]} -> {occurCount[i]}");
        }
    }
}
