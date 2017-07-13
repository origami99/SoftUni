using System;
using System.Collections.Generic;
using System.Linq;

class ChangeList
{
    static void Main()
    {
        List<int> nums = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToList();

        string[] command = new string[2];
        while (true)
        {
            command = Console.ReadLine()
                .Split(' ')
                .ToArray();

            if (command[0] == "Delete")
            {
                nums.RemoveAll(x => x == int.Parse(command[1]));
            }
            else if(command[0] == "Insert")
            {
                nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
            }
            else if(command[0] == "Even" || command[0] == "Odd")
            {
                break;
            }
        }

        if (command[0] == "Even")
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 != 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }
        else
        {
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    nums.RemoveAt(i);
                    i--;
                }
            }
        }

        Console.WriteLine(string.Join(" ", nums));
    }
}
