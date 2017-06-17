using System;
using System.Collections.Generic;

class FixEmails
{
    static void Main()
    {
        string name = Console.ReadLine().Trim();
        Dictionary<string, string> contacts = new Dictionary<string, string>();

        while (name != "stop")
        {
            string email = Console.ReadLine().Trim();
            if (!(email.EndsWith("us") || email.EndsWith("us")))
            {
                contacts[name] = email;
            }

            name = Console.ReadLine().Trim();
        }

        foreach (var item in contacts)
        {
            Console.WriteLine("{0} -> {1}",
                item.Key, item.Value);
        }
    }
}
