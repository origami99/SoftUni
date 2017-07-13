using System;
using System.Collections.Generic;
using System.Linq;

class Pokemon
{
    public string Name { get; set; }
    public List<string> EvolType { get; set; }
    public List<int> EvolIndex { get; set; }
}

class Program
{
    static void Main()
    {
        List<Pokemon> pokemons = new List<Pokemon>();

        while (true)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '\t', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "wubbalubbadubdub")
            {
                break;
            }

            if (input.Length > 1)
            {

            }

            string pokemonName = input[0];
            string evolutionType = input[1];
            int evolutionIndex = int.Parse(input[2]);

            Pokemon pokemon = new Pokemon();
            pokemon.EvolType = new List<string>();
            pokemon.EvolIndex = new List<int>();

            pokemon.Name = pokemonName;
            pokemon.EvolType.Add(evolutionType);
            pokemon.EvolIndex.Add(evolutionIndex);

            pokemons.Add(pokemon);
        }

        foreach (Pokemon pkm in pokemons)
        {
            Console.WriteLine($"# {pkm.Name}");

            for (int i = 0; i < pkm.EvolType.Count; i++)
            {
                Console.WriteLine($"{pkm.EvolType[i]} <-> {pkm.EvolIndex[i]}");
            }
        }
    }
}
