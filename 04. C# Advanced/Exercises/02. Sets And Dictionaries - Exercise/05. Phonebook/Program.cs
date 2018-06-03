using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();

        while (true)
        {
            string[] input = Console.ReadLine().Split('-');

            if (input[0].ToLower() == "search")
            {
                break;
            }

            string name = input[0];
            string phone = input[1];

            phonebook[name] = phone;
        }

        while (true)
        {
            string name = Console.ReadLine();

            if (name.ToLower() == "stop")
            {
                break;
            }

            if (phonebook.ContainsKey(name))
            {
                Console.WriteLine(name + " -> " + phonebook[name]);
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }

    }
}
