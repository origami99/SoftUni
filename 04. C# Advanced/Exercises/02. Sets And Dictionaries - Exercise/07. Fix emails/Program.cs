using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (true)
        {
            string name = Console.ReadLine();
            if (name == "stop") { break; }
            string email = Console.ReadLine();
            
            contacts[name] = email;
        }

        contacts = contacts
            .Where(x => !x.Value.EndsWith("us") && !x.Value.EndsWith("uk"))
            .ToDictionary(x => x.Key, x => x.Value);

        foreach (KeyValuePair<string, string> res in contacts)
        {
            Console.WriteLine(res.Key + " -> " + res.Value);
        }
    }
}
