using System;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        if (nums.Length == 1)
        {
            Console.WriteLine(0);
            return;
        }

        bool hasEqualSums = false;

        for (int i = 0; i < nums.Length; i++)
        {
            int leftSum = nums.Take(i).Sum();
            int rightSum = nums.Skip(i + 1).Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine(i);
                hasEqualSums = true;
                return;
            }
        }

        if (!hasEqualSums)
        {
            Console.WriteLine("no");
        }
    }
}
