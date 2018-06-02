using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        int n = int.Parse(input.Substring(0, 1));
        int m = int.Parse(input.Substring(2, 1));

        HashSet<int> firstSet = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            firstSet.Add(num);
        }

        HashSet<int> secondSet = new HashSet<int>();
        for (int i = 0; i < m; i++)
        {
            int num = int.Parse(Console.ReadLine());
            secondSet.Add(num);
        }

        HashSet<int> lastSet = new HashSet<int>();
        foreach (int num in firstSet)
        {
            if (secondSet.Contains(num))
            {
                lastSet.Add(num);
            }
        }

        Console.WriteLine(string.Join(" ", lastSet));
    }
}
