using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        SortedDictionary<char, int> occurs = new SortedDictionary<char, int>();
        foreach (char symb in text)
        {
            if (!occurs.ContainsKey(symb))
            {
                occurs.Add(symb, 1);
            }
            else
            {
                occurs[symb]++;
            }
        }

        foreach (KeyValuePair<char, int> occur in occurs)
        {
            Console.WriteLine($"{occur.Key}: {occur.Value} time/s");
        }
    }
}
