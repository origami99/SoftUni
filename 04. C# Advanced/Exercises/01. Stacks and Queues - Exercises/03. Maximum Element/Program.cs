using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> nums = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int firstNum = input.First();

            switch (firstNum)
            {
                case 1:
                    int x = input.Last();
                    nums.Push(x);
                    break;
                case 2:
                    if (nums.Count != 0)
                    {
                        nums.Pop();
                    }
                    break;
                case 3:
                    if (nums.Count != 0)
                    {
                        Console.WriteLine(nums.Max());
                    }
                    break;
            }
        }
    }
}
