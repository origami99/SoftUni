using System;
using System.Collections.Generic;
using System.Linq;

class SumReversedNumbers
{
    static void Main()
    {
        List<string> nums = Console.ReadLine()
            .Split(' ')
            .ToList();

        for (int i = 0; i < nums.Count; i++)
        {
            bool isPositive = true;
            string revNum = "";

            for (int j = nums[i].Length - 1; j >= 0; j--)
            {
                if (nums[i][j] != '-')
                {
                    revNum = revNum + nums[i][j];
                }
                else
                {
                    isPositive = false;
                }
            }

            if (isPositive)
            {
                nums[i] = revNum;
            }
            else
            {
                nums[i] = "-" + revNum;
            }
        }

        int sum = nums.Select(int.Parse).Sum();
        Console.WriteLine(sum);
    }
}
