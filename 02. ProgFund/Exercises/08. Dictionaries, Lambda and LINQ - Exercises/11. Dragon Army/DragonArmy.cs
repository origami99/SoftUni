using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class DragonArmy
{
    public static void Main()
    {
        var dragons = new Dictionary<string, SortedDictionary<string, int[]>>();
        var regex = new Regex(@"([a-zA-Z]*)\s*([a-zA-Z]*)\s*(null|\d+)\s*(null|\d+)\s*(null|\d+)");

        var n = int.Parse(Console.ReadLine());

        for (var i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            var match = regex.Match(input);

            if (match.Success)
            {
                var type = match.Groups[1].Value;
                var name = match.Groups[2].Value;
                var damage = 0;
                var health = 0;
                var armor = 0;
                damage = match.Groups[3].Value == "null" ? 45 : int.Parse(match.Groups[3].Value);
                health = match.Groups[4].Value == "null" ? 250 : int.Parse(match.Groups[4].Value);
                armor = match.Groups[5].Value == "null" ? 10 : int.Parse(match.Groups[5].Value);

                if (!dragons.ContainsKey(type))
                {
                    dragons.Add(type, new SortedDictionary<string, int[]>());
                }

                if (!dragons[type].ContainsKey(name))
                {
                    dragons[type][name] = new int[3];
                }

                dragons[type][name][0] = damage;
                dragons[type][name][1] = health;
                dragons[type][name][2] = armor;
            }
        }

        foreach (var typ in dragons)
        {
            Console.WriteLine("{0}::({1:F}/{2:f}/{3:f})", typ.Key, typ.Value.Select(x => x.Value[0]).Average(),
               typ.Value.Select(x => x.Value[1]).Average(), typ.Value.Select(x => x.Value[2]).Average());

            foreach (var item in typ.Value)
            {
                Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", item.Key, item.Value[0],
                    item.Value[1], item.Value[2]);
            }
        }
    }
}
