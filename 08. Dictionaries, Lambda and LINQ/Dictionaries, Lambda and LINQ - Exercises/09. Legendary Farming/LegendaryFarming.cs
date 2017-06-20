using System;
using System.Collections.Generic;
using System.Linq;

class LegendaryFarming
{
    static void Main()
    {
        Dictionary<string, int> materials = new Dictionary<string, int>()
        {
            { "shards", 0 },
            { "fragments", 0 },
            { "motes", 0 }
        };
        while (true)
        {
            string[] resourse;
            int[] quantities;
            ReceiveMaterials(out resourse, out quantities);

            for (int i = 0; i < resourse.Length; i++)
            {
                string item = resourse[i];
                int quantity = quantities[i];

                if (materials.ContainsKey(item))
                {
                    materials[item] += quantity;
                }
                else
                {
                    materials[item] = quantity;
                }

                if (materials["shards"] >= 250 ||
                    materials["fragments"] >= 250 ||
                    materials["motes"] >= 250)
                {
                    goto Exit;
                }
            }
        }
        Exit:

        PrintObtainedLegendaryItem(materials);

        materials = OrderByValueThenByName(materials);

        PrintKeyMaterials(materials);

        RemoveKeyMaterials(materials);

        materials = OrderByName(materials);

        PrintJunkMaterials(materials);
    }

    private static Dictionary<string, int> OrderByName(Dictionary<string, int> materials)
    {
        materials = materials
            .OrderBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        return materials;
    }

    private static void ReceiveMaterials(out string[] resourse, out int[] quantities)
    {
        string[] loot = Console.ReadLine()
            .Split(' ')
            .ToArray();

        resourse = loot
            .Where((x, i) => i % 2 != 0)
            .Select(x => x.ToLower())
            .ToArray();
        quantities = loot
            .Where((x, i) => i % 2 == 0)
            .Select(x => int.Parse(x))
            .ToArray();
    }

    private static void PrintObtainedLegendaryItem(Dictionary<string, int> materials)
    {
        if (materials["shards"] >= 250)
        {
            Console.WriteLine("Shadowmourne obtained!");
            materials["shards"] -= 250;
        }
        else if (materials["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            materials["fragments"] -= 250;
        }
        else if (materials["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            materials["motes"] -= 250;
        }
    }

    private static Dictionary<string, int> OrderByValueThenByName(Dictionary<string, int> materials)
    {
        materials = materials
            .OrderByDescending(x => x.Value)
            .ThenBy(x => x.Key)
            .ToDictionary(x => x.Key, x => x.Value);

        return materials;
    }

    private static void PrintKeyMaterials(Dictionary<string, int> materials)
    {
        foreach (var item in materials)
        {
            if (item.Key == "shards" ||
                item.Key == "fragments" || 
                item.Key == "motes")
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }

    private static void RemoveKeyMaterials(Dictionary<string, int> materials)
    {
        materials.Remove("shards");
        materials.Remove("fragments");
        materials.Remove("motes");
    }

    private static void PrintJunkMaterials(Dictionary<string, int> materials)
    {
        foreach (var junk in materials)
        {
            Console.WriteLine($"{junk.Key}: {junk.Value}");
        }
    }
}
