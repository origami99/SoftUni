using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, SortedDictionary<string, int>> logs = new SortedDictionary<string, SortedDictionary<string, int>>();
        for (int i = 0; i < n; i++)
        {
            string ip, user;
            int duration;
            InputData(out ip, out user, out duration);

            AddsDataToDictionary(logs, ip, user, duration);
        }

        PrintDictionaryData(logs);
    }

    private static void InputData(out string ip, out string user, out int duration)
    {
        string[] input = Console.ReadLine()
            .Split(' ')
            .ToArray();

        ip = input[0];
        user = input[1];
        duration = int.Parse(input[2]);
    }

    private static void AddsDataToDictionary(SortedDictionary<string, SortedDictionary<string, int>> logs, string ip, string user, int duration)
    {
        if (logs.ContainsKey(user))
        {
            if (logs[user].ContainsKey(ip))
            {
                logs[user][ip] += duration;
            }
            else
            {
                logs[user][ip] = duration;
            }
        }
        else
        {
            logs.Add(user, new SortedDictionary<string, int> { { ip, duration } });
        }
    }

    private static void PrintDictionaryData(SortedDictionary<string, SortedDictionary<string, int>> logs)
    {
        foreach (var usr in logs)
        {
            Console.Write($"{usr.Key}: {usr.Value.Values.Sum()} ");

            Console.WriteLine("[" + string.Join(", ", usr.Value.Select(x => x.Key).ToArray()) + "]");
        }
    }
}
