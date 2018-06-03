using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        SortedDictionary<string, Dictionary<string, int>> users = new SortedDictionary<string, Dictionary<string, int>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(' ');

            if (input[0] == "end") { break; }

            string ip = input[0].Substring(3);
            string message = input[1];
            string username = input[2].Substring(5);

            if (!users.ContainsKey(username))
            {
                users.Add(username, new Dictionary<string, int>() { { ip, 1 } });
            }
            else
            {
                if (!users[username].ContainsKey(ip))
                {
                    users[username].Add(ip, 1);
                }
                else
                {
                    users[username][ip]++;
                }
            }
        }

        foreach (KeyValuePair<string, Dictionary<string, int>> user in users)
        {
            Console.WriteLine($"{user.Key}: ");

            string ips = string.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}")) + '.';
            Console.WriteLine(ips);
        }
    }
}
