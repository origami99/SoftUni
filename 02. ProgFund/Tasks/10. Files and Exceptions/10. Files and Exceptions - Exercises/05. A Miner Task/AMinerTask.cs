using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main()
    {
        Dictionary<string, long> resourses = new Dictionary<string, long>();

        int counter = 0;
        while (true)
        {
            string res = Console.ReadLine();
            if (res == "stop")
            {
                break;
            }
            int amount = int.Parse(Console.ReadLine());

            if (resourses.ContainsKey(res)) 
            {
                resourses[res] += amount;
            }
            else
            {
                resourses[res] = amount;
            }

            counter++;
        }

        foreach (KeyValuePair<string, long> ore in resourses)
        {
            Console.WriteLine($"{ore.Key} -> {ore.Value}");
        }
    }
}
