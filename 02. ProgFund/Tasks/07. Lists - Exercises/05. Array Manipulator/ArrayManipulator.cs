using System;
using System.Collections.Generic;
using System.Linq;

class ArrayManipulator
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        List<string> commands = new List<string>();
        while (true)
        {
            commands = Console.ReadLine()
                .Split(' ')
                .ToList();

            if (commands[0] == "print")
            {
                break;
            }

            switch (commands[0])
            {
                case "add":
                    Add(ref nums, commands);
                    break;
                case "addMany":
                    AddMany(ref nums, commands);
                    break;
                case "contains":
                    Contains(ref nums, commands);
                    break;
                case "remove":
                    Remove(ref nums, commands);
                    break;
                case "shift":
                    Shift(ref nums, commands);
                    break;
                case "sumPairs":
                    SumPairs(ref nums, commands);
                    break;
            }
        }

        Console.WriteLine("[" + string.Join(", ", nums) + "]");
    }

    private static void Add(ref List<int> nums, List<string> commands)
    {
        nums.Insert(
            int.Parse(commands[1]),
            int.Parse(commands[2]));
    }

    private static void AddMany(ref List<int> nums, List<string> commands)
    {
        int index = int.Parse(commands[1]);

        List<int> numsToAdd = new List<int>();
        for (int i = 2; i < commands.Count; i++)
        {
            numsToAdd.Add(int.Parse(commands[i]));
        }

        nums.InsertRange(index, numsToAdd);
    }

    private static void Contains(ref List<int> nums, List<string> commands)
    {
        if (nums.Contains(int.Parse(commands[1])))
        {
            int index = nums.FindIndex(
                x => x == int.Parse(commands[1]));
            Console.WriteLine(index);
        }
        else
        {
            Console.WriteLine(-1);
        }
    }

    private static void Remove(ref List<int> nums, List<string> commands)
    {
        nums.RemoveAt(int.Parse(commands[1]));
    }

    private static void Shift(ref List<int> nums, List<string> commands)
    {
        int positions = int.Parse(commands[1]);

        for (int i = 0; i < positions; i++)
        {
            int lastElement = nums[0];

            for (int j = 0; j < nums.Count - 1; j++)
            {
                nums[j] = nums[j + 1];
            }

            nums[nums.Count - 1] = lastElement;
        }
    }

    private static void SumPairs(ref List<int> nums, List<string> commands)
    {
        List<int> tempNums = new List<int>(nums);
        nums.Clear();

        for (int i = 0; i < tempNums.Count; i++)
        {
            if (tempNums.Count % 2 != 0 && i == tempNums.Count - 1)
            {
                nums.Add(tempNums[tempNums.Count - 1]);
                break;
            }

            if (i % 2 == 0)
            {
                nums.Add(tempNums[i] + tempNums[i + 1]);
            }
        }
    }
}
