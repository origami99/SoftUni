using System;
using System.Linq;

class SortTimes
{
    static void Main()
    {
        string[] times = Console.ReadLine()
            .Split(' ')
            .OrderBy(x => x)
            .ToArray();

        Console.WriteLine(string.Join(", ", times));
    }
}
