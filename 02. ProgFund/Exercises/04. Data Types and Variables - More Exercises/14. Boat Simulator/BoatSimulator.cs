using System;

class BoatSimulator
{
    static void Main()
    {
        char charBoat1 = char.Parse(Console.ReadLine());
        char charBoat2 = char.Parse(Console.ReadLine());
        byte n = byte.Parse(Console.ReadLine());

        int tilesBoat1 = 0;
        int tilesBoat2 = 0;

        for (byte i = 1; i <= n; i++)
        {
            string action = Console.ReadLine();

            if (action == "UPGRADE")
            {
                charBoat1 = (char)(charBoat1 + 3);
                charBoat2 = (char)(charBoat2 + 3);
                continue;
            }

            if (i % 2 != 0)
            {
                tilesBoat1 += action.Length;

                if (tilesBoat1 >= 50)
                {
                    Console.WriteLine(charBoat1);
                    return;
                }
            }
            else
            {
                tilesBoat2 += action.Length;

                if (tilesBoat2 >= 50)
                {
                    Console.WriteLine(charBoat2);
                    return;
                }
            }
        }

        if (tilesBoat1 > tilesBoat2)
        {
            Console.WriteLine(charBoat1);
        }
        else
        {
            Console.WriteLine(charBoat2);
        }
    }
}
