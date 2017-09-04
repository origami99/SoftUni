using System;
using System.Linq;

class ShortWordsSorted
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .ToLower()
            .Split(".,:;()[]'\"\\/!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Distinct()
            .ToArray();

        words = words
            .Where(x => x.Length < 5)
            .OrderBy(x => x)
            .ToArray();

        Console.WriteLine(string.Join(", ", words));
    }
}
