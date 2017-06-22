using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class SortTimes
{
    static void Main()
    {
        IEnumerable<DateTime> times = Console.ReadLine()
            .Split(' ')
            .Select(x => DateTime.ParseExact(x, "HH:mm", CultureInfo.InvariantCulture))
            .OrderBy(x => x);

        PrintResult(times);
    }

    private static void PrintResult(IEnumerable<DateTime> times)
    {
        int counter = 0;
        foreach (var item in times)
        {
            counter++;
            Console.Write(string.Format($"{item:HH:mm}"));
            if (counter != times.Count())
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
