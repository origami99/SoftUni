using System;
using System.Collections.Generic;
using System.Linq;

class SearchForANumber
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();
        int[] actions = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Take(ref nums, actions);
        Delete(nums, actions);

        if (nums.Contains(actions[2]))
        {
            Console.WriteLine("YES!");
        }
        else
        {
            Console.WriteLine("NO!");
        }
    }

    private static void Take(ref List<int> nums, int[] actions)
    {
        for (int i = actions[0]; i < nums.Count; i++)
        {
            nums.RemoveAt(actions[0]);
        }
    }

    private static void Delete(List<int> nums, int[] actions)
    {
        for (int i = 0; i < actions[1]; i++)
        {
            nums.RemoveAt(0);
        }
    }
}
