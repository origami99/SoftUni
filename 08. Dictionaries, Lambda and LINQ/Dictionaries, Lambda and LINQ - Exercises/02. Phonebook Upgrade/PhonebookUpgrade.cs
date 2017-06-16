using System;
using System.Collections.Generic;
using System.Linq;

class PhonebookUpgrade
{
    static void Main()
    {
        string[] entry = Console.ReadLine()
            .Split(' ')
            .ToArray();

        SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

        while (entry[0] != "END")
        {

            switch (entry[0])
            {
                case "A":
                    phonebook[entry[1]] = entry[2];
                    break;
                case "S":
                    if (phonebook.ContainsKey(entry[1]))
                    {
                        Console.WriteLine($"{entry[1]} -> {phonebook[entry[1]]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {entry[1]} does not exist.");
                    }
                    break;
                case "ListAll":
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine("{0} -> {1}",
                            item.Key, item.Value);
                    }
                    break;
            }

            entry = Console.ReadLine()
                .Split(' ')
                .ToArray();
        }
    }
}
