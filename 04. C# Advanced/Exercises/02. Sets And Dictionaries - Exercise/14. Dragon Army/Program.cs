using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, SortedDictionary<string, int[]>> dragons = new Dictionary<string, SortedDictionary<string, int[]>>();

        for (int i = 0; i < n; i++)
        {
            string[] dragon = Console.ReadLine().Split(' ');

            string type = dragon[0];
            string name = dragon[1];
            int damage = dragon[2] == "null" ? 45 : int.Parse(dragon[2]);
            int health = dragon[3] == "null" ? 250 : int.Parse(dragon[3]);
            int armor = dragon[4] == "null" ? 10 : int.Parse(dragon[4]);
            int[] stats = new int[] { damage, health, armor };

            if (!dragons.ContainsKey(type))
            {
                dragons.Add(type, new SortedDictionary<string, int[]>() { { name, stats } });
            }
            else
            {
                dragons[type][name] = stats;
            }
        }

        foreach (KeyValuePair<string, SortedDictionary<string, int[]>> dragon in dragons)
        {
            double avgDamage = dragon.Value.Values.Average(x => x[0]);
            double avgHealth = dragon.Value.Values.Average(x => x[1]);
            double avgArmor = dragon.Value.Values.Average(x => x[2]);

            Console.WriteLine($"{dragon.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgArmor:F2})");

            foreach (KeyValuePair<string, int[]> item in dragon.Value)
            {
                Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}");
            }
        }
    }
}
