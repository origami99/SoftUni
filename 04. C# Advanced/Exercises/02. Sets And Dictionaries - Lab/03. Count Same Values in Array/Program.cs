using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] values = Console.ReadLine().Split(' ');

        SortedDictionary<string, int> occurs = new SortedDictionary< string, int>();

        foreach (string value in values)
        {
            if (!occurs.ContainsKey(value))
            {
                occurs.Add(value , 1);
            }
            else
            {
                occurs[value]++;
            }
        }

        string[] result = occurs.Select(x => x.Key + " - " + x.Value + " times").ToArray();
        Console.WriteLine(string.Join("\n", result));
    }
}
