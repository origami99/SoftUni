using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Split(new string[] { "IP=", " message='", "' user=" }, StringSplitOptions.None)
            .ToArray();

        string user = "";
        string ip = "";
        if (input[0] != "end")
        {
            input = input.Skip(1).ToArray();
            user = input[2];
            ip = input[0];
        }

        SortedDictionary<string, Dictionary<string, int>> userData = new SortedDictionary<string, Dictionary<string, int>>();
        while (input[0] != "end")
        {
            if (userData.ContainsKey(user))
            {
                if (userData[user].ContainsKey(ip))
                {
                    userData[user][ip]++;
                }
                else
                {
                    userData[user][ip] = 1;
                }
            }
            else
            {
                userData.Add(user, new Dictionary<string, int> { { ip, 1 } });
            }

            input = Console.ReadLine()
                .Split(new string[] { "IP=", " message='", "' user=" }, StringSplitOptions.None)
                .ToArray();

            if (input[0] != "end")
            {
                input = input.Skip(1).ToArray();
                user = input[2];
                ip = input[0];
            }
        }

        foreach (var userr in userData)
        {
            Console.WriteLine(userr.Key + ": ");

            int counter = 0;
            foreach (var item in userr.Value)
            {
                if (counter < userr.Value.Count - 1)
                {
                    Console.Write("{0} => {1}, ",
                        item.Key, item.Value);

                    counter++;
                }
                else
                {
                    Console.WriteLine("{0} => {1}.",
                        item.Key, item.Value);
                }
            }
        }
    }
}
