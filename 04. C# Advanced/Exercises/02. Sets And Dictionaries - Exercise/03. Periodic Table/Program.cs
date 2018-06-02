using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedSet<string> elements = new SortedSet<string>();
        for (int i = 0; i < n; i++)
        {
            string[] copounds = Console.ReadLine().Split(' ');

            foreach (var element in copounds)
            {
                elements.Add(element);
            }
        }

        Console.WriteLine(string.Join(" ", elements));
    }
}
