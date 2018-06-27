using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Tuple<int, int> playerPos = new Tuple<int, int>(7, 7); 

        int pHealth = 18500;
        double heiganHealth = 3000000.0;
        double heiganDamage = double.Parse(Console.ReadLine());
        string lastSpell = string.Empty;

        while (true)
        {
            if (pHealth >= 0)
            {
                heiganHealth -= heiganDamage;
            }
            if (lastSpell == "Plague Cloud")
            {
                pHealth -= 3500;
            }
            if (heiganHealth <= 0 || pHealth <= 0)
            {
                break;
            }

            string[] input = Console.ReadLine().Split();
            string spell = input[0];
            int hitRow = int.Parse(input[1]);
            int hitCol = int.Parse(input[2]);

            List<Tuple<int, int>> damagedPos = new List<Tuple<int, int>>()
            {
                new Tuple<int, int>(hitRow - 1, hitCol - 1),
                new Tuple<int, int>(hitRow - 1, hitCol),
                new Tuple<int, int>(hitRow - 1, hitCol + 1),
                new Tuple<int, int>(hitRow, hitCol - 1),
                new Tuple<int, int>(hitRow, hitCol),
                new Tuple<int, int>(hitRow, hitCol + 1),
                new Tuple<int, int>(hitRow + 1, hitCol - 1),
                new Tuple<int, int>(hitRow + 1, hitCol),
                new Tuple<int, int>(hitRow + 1, hitCol + 1)
            };

            if (damagedPos.Contains(playerPos))
            {
                lastSpell = string.Empty;

                if (!damagedPos.Contains(new Tuple<int, int>(playerPos.Item1 - 1, playerPos.Item2)) && isInBounds(playerPos.Item1 - 1))
                {
                    playerPos = new Tuple<int, int>(playerPos.Item1 - 1, playerPos.Item2); // move up
                }
                else if (!damagedPos.Contains(new Tuple<int, int>(playerPos.Item1, playerPos.Item2 + 1)) && isInBounds(playerPos.Item2 + 1))
                {
                    playerPos = new Tuple<int, int>(playerPos.Item1, playerPos.Item2 + 1); // move right
                }
                else if (!damagedPos.Contains(new Tuple<int, int>(playerPos.Item1 + 1, playerPos.Item2)) && isInBounds(playerPos.Item1 + 1))
                {
                    playerPos = new Tuple<int, int>(playerPos.Item1 + 1, playerPos.Item2); // move down
                }
                else if (!damagedPos.Contains(new Tuple<int, int>(playerPos.Item1, playerPos.Item2 - 1)) && isInBounds(playerPos.Item2 - 1))
                {
                    playerPos = new Tuple<int, int>(playerPos.Item1, playerPos.Item2 - 1); // move left
                }
                else
                {
                    switch (spell)
                    {
                        case "Cloud":
                            pHealth -= 3500;
                            lastSpell = "Plague Cloud";
                            break;
                        case "Eruption":
                            pHealth -= 6000;
                            lastSpell = "Eruption";
                            break;
                    }
                }
            }
        }

        if (heiganHealth <= 0)
        {
            Console.WriteLine("Heigan: Defeated!");
        }
        else
        {
            Console.WriteLine($"Heigan: {heiganHealth:F2}");
        }

        if (pHealth <= 0)   
        {
            if (lastSpell != "Plague Cloud")
            {
                lastSpell = "Eruption";
            }
            Console.WriteLine($"Player: Killed by {lastSpell}");
        }
        else
        {
            Console.WriteLine($"Player: {pHealth}");
        }

        Console.WriteLine($"Final position: {playerPos.Item1}, {playerPos.Item2}");
    }

    private static bool isInBounds(int cell)
    {
        return cell >= 0 && cell < 15;
    }
}
