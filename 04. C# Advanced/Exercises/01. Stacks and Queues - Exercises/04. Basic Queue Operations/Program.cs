using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] sequence = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int n = input.First();
        int s = input[1];
        int x = input.Last();

        Queue<int> nums = new Queue<int>(sequence.Take(n));

        for (int i = 0; i < s; i++)
        {
            if (nums.Count == 0)
            {
                break;
            }

            nums.Dequeue();
        }

        if (nums.Contains(x))
        {
            Console.WriteLine("true");
        }
        else
        {
            int minNum = nums.Count != 0 ? nums.Min() : 0;
            Console.WriteLine(minNum);
        }
    }
}
