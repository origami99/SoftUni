using System;
using System.Collections.Generic;
using System.Linq;

class ImmuneSystem
{
    static void Main()
    {
        int health = int.Parse(Console.ReadLine());
        string virus = Console.ReadLine();
        int initialHealth = health;

        Dictionary<string, string[]> fights = new Dictionary<string, string[]>();
        while (virus != "end")
        {
            int virusStrength = GetVirusStrength(virus);
            int virusDefeatSeconds = GetVirusDefeatSeconds(virus, fights, virusStrength);
            string time = GetTime(virusDefeatSeconds);
            health -= virusDefeatSeconds;

            fights[virus] = new string[] { virusStrength.ToString(), virusDefeatSeconds.ToString(), time };

            Console.WriteLine($"Virus {virus}: {fights[virus][0]} => {fights[virus][1]} seconds");
            if (health <= 0)
            {
                Console.WriteLine("Immune System Defeated.");
                return;
            }
            Console.WriteLine($"{virus} defeated in {fights[virus][2]}.");
            Console.WriteLine($"Remaining health: {health}");

            if (health * 1.20 <= initialHealth)
            {
                health = (int)(health * 1.20);
            }
            else
            {
                health = initialHealth;
            }

            virus = Console.ReadLine();
        }

        Console.WriteLine($"Final Health: {health}");
    }

    private static int GetVirusStrength(string virus)
    {
        int virusStrength = virus
            .ToArray()
            .Select(x => (int)x)
            .Sum();
        virusStrength /= 3;

        return virusStrength;
    }

    private static int GetVirusDefeatSeconds(string virus, Dictionary<string, string[]> fights, int virusStrength)
    {
        int virusDefeatSeconds = virusStrength * virus.Length;
        if (fights.ContainsKey(virus))
        {
            virusDefeatSeconds /= 3;
        }

        return virusDefeatSeconds;
    }

    static string GetTime(int virusDefeatSeconds)
    {
        int mins = virusDefeatSeconds / 60;
        int seconds = virusDefeatSeconds % 60;

        string time = string.Format($"{mins}m {seconds}s");

        return time;
    }
}
