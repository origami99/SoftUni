using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> pokeInfo = new Dictionary<string, Dictionary<string, int>>();
        while (true)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "wubbalubbadubdub")
            {
                break;
            }

            string pokemonName = input[0];
            string evolutionType = input[1];
            int evolutionIndex = int.Parse(input[2]);

            //if (userData.ContainsKey(user))
            //{
            //    if (userData[user].ContainsKey(ip))
            //    {
            //        userData[user][ip]++;
            //    }
            //    else
            //    {
            //        userData[user][ip] = 1;
            //    }
            //}
            //else
            //{
            //    userData.Add(user, new Dictionary<string, int> { { ip, 1 } });
            //}

            if (pokeInfo.ContainsKey(pokemonName))
            {
                pokeInfo[pokemonName].Add(evolutionType, evolutionIndex);
            }
            else
            {
                pokeInfo.Add(pokemonName, new Dictionary<string, int> { { evolutionType, evolutionIndex } });
            }
        }

        for (int i = 0; i < pokeInfo.Count; i++)
        {
            var evol = pokeInfo.ElementAt(i);

            pokeInfo[evol.Key] = pokeInfo[evol.Key]
                .OrderByDescending(x => x.Value)
                .ToDictionary(x => x.Key, x => x.Value);
        }


        foreach (var pkm in pokeInfo)
        {
            Console.WriteLine($"# {pkm.Key}");

            foreach (var evol in pkm.Value)
            {
                Console.WriteLine($"{evol.Key} <-> {evol.Value}");
            }
        }
    }
}
