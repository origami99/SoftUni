using System;
using System.Collections.Generic;
using System.Linq;

class Phonebook
{
    static void Main()
    {
        string[] entry = Console.ReadLine()
            .Split(' ')
            .ToArray();

        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (entry[0] != "END")
        {
            if (entry[0] == "A")
            {
                phonebook[entry[1]] = entry[2];
            }
            else if (entry[0] == "S")
            {
                if (phonebook.ContainsKey(entry[1]))
                {
                    Console.WriteLine($"{entry[1]} -> {phonebook[entry[1]]}");
                }
                else
                {
                    Console.WriteLine($"Contact {entry[1]} does not exist.");
                }
            }

            entry = Console.ReadLine()
                .Split(' ')
                .ToArray();
        }
    }
}
