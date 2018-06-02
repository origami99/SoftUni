using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> usernames = new HashSet<string>();
        for (int i = 0; i < 6; i++)
        {
            string username = Console.ReadLine();

            usernames.Add(username);
        }

        Console.WriteLine(string.Join("\n", usernames));
    }
}
