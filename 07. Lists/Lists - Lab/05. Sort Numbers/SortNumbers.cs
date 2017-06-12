using System;
using System.Linq;
using System.Collections.Generic;

class SortNumbers
{
    static void Main()
    {
        List<double> nums = Console.ReadLine()
            .Split(' ')
            .Select(double.Parse)
            .ToList();

        nums.Sort();

        Console.WriteLine(string.Join(" <= ", nums));
    }
}
