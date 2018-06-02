using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedSet<string> guest = new SortedSet<string>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "PARTY") { break; }

            guest.Add(input);
        }

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "END") { break; }

            guest.Remove(input);
        }

        Console.WriteLine(string.Join("\n", guest));
    }
}
