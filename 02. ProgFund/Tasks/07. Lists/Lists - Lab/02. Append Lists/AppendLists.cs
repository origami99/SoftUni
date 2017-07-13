using System;
using System.Linq;
using System.Collections.Generic;

class AppendLists
{
    static void Main()
    {
        List<string> sequences = Console.ReadLine()
            .Split('|')
            .ToList();

        List<int> nums = new List<int>();

        for (int i = sequences.Count - 1; i >= 0; i--)
        {
            List<int> temp = sequences[i]
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            foreach (var num in temp)
            {
                nums.Add(num);
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}
