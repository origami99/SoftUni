using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Dictionary<string, HashSet<string>> players = new Dictionary<string, HashSet<string>>();

        while (true)
        {
            string[] input = Console.ReadLine().Split(':');

            if (input[0] == "JOKER") { break; }

            string name = input[0];
            HashSet<string> cards = new HashSet<string>(
                input[1].Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries));

            if (!players.ContainsKey(name))
            {
                players.Add(name, cards);
            }
            else
            {
                players[name].UnionWith(cards);
            }
        }

        foreach (KeyValuePair<string, HashSet<string>> player in players)
        {
            int points = GetPlayerPoints(player.Value);
            
            Console.WriteLine($"{player.Key}: {points}");
        }
    }

    private static int GetPlayerPoints(HashSet<string> cards)
    {
        int points = 0;

        string[] powers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] types = { "0", "C", "D", "H", "S" };

        int power = 0;
        int type = 0;

        foreach (string card in cards)
        {
            if (card.Length == 3)
            {
                power = 10;
                type = Array.IndexOf(types, card[2].ToString());
            }
            else
            {
                power = Array.IndexOf(powers, card[0].ToString());
                type = Array.IndexOf(types, card[1].ToString());
            }

            points += power * type;
        }

        return points;
    }
}
