using System;
using System.Collections.Generic;

class AMinerTask
{
    static void Main()
    {
        string resource = Console.ReadLine();

        Dictionary<string, long> inventar = new Dictionary<string, long>();

        while (resource != "stop")
        {
            long quantity = long.Parse(Console.ReadLine());

            if (inventar.ContainsKey(resource))
            {
                inventar[resource] += quantity;
            }
            else
            {
                inventar[resource] = quantity;
            }

            resource = Console.ReadLine();
        }

        foreach (var item in inventar)
        {
            Console.WriteLine("{0} -> {1}",
                item.Key, item.Value);
        }
    }
}
