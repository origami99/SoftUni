using System;
using System.Linq;

class Largest3Numbers
{
    static void Main()
    {
        int[] nums = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();

        nums = nums
            .OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        Console.WriteLine(string.Join(" ", nums));
    }
}
