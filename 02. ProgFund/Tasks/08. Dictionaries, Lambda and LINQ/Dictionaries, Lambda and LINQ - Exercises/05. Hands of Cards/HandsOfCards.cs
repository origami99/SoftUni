using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main()
    {
        string[] draw = Console.ReadLine()
            .Split(':')
            .Distinct()
            .ToArray();

        Dictionary<string, string> cards = new Dictionary<string, string>();
        while (draw[0] != "JOKER")
        {
            if (cards.ContainsKey(draw[0]))
            {
                cards[draw[0]] = cards[draw[0]] + draw[1] + " ";
            }
            else
            {
                cards[draw[0]] = draw[1] + " ";
            }

            draw = Console.ReadLine()
                .Split(':')
                .Distinct()
                .ToArray();
        }

        Dictionary<string, int> points = new Dictionary<string, int>();
        foreach (var item in cards)
        {
            if (points.ContainsKey(item.Key))
            {
                points[item.Key] += CalculatePoints(item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray());
            }
            else
            {
                points[item.Key] = CalculatePoints(item.Value.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray());
            }
        }

        foreach (var item in points)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }
    }

    static int CalculatePoints(string[] draw)
    {
        int points = 0;
        int power = 0;
        int type = 0;

        foreach (var card in draw)
        {
            if (card.Length == 3)
            {
                power = 10;
            }
            else
            {
                switch (card[0])
                {
                    case 'J':
                        power = 11;
                        break;
                    case 'Q':
                        power = 12;
                        break;
                    case 'K':
                        power = 13;
                        break;
                    case 'A':
                        power = 14;
                        break;
                    default:
                        power = card[0] - '0'; 
                        break;
                }
            }

            switch (card[card.Length - 1])
            {
                case 'S':
                    type = 4;
                    break;
                case 'H':
                    type = 3;
                    break;
                case 'D':
                    type = 2;
                    break;
                case 'C':
                    type = 1;
                    break;
            }

            points += power * type;
        }

        return points;
    }
}
