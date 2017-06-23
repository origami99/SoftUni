using System;
using System.Collections.Generic;
using System.Linq;

class ParkingValidation
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<string, string> plates = new Dictionary<string, string>();
        for (int i = 0; i < n; i++)
        {
            string[] license = Console.ReadLine()
                .Split(' ')
                .ToArray();

            string username = license[1];

            if (license[0] == "register")
            {
                string code = license[2];

                bool isValidCode = IsValidCode(code);

                if (plates.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {plates[username]}");
                }
                else if (!isValidCode)
                {
                    Console.WriteLine($"ERROR: invalid license plate {code}");
                }
                else if (plates.ContainsValue(code))
                {
                    Console.WriteLine($"ERROR: license plate {code} is busy");
                }
                else
                {
                    plates[username] = code;
                    Console.WriteLine($"{username} registered {code} successfully");
                }
            }
            else
            {
                if (!plates.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
                else
                {
                    plates.Remove(username);
                    Console.WriteLine($"user {username} unregistered successfully");
                }
            }
        }

        foreach (var reg in plates)
        {
            Console.WriteLine($"{reg.Key} => {reg.Value}");
        }
    }

    private static bool IsValidCode(string code)
    {
        if (code.Length != 8)
        {
            return false;
        }

        // Checks are first two letters upper
        for (int i = 0; i < 2; i++)
        {
            if (!Char.IsUpper(code[i]))
            {
                return false;
            }
        }

        // Checks are last two letters upper
        for (int i = 6; i < 8; i++)
        {
            if (!Char.IsUpper(code[i]))
            {
                return false;
            }
        }

        // Checks are middle four symbols digits
        for (int i = 2; i < 6; i++)
        {
            if (!Char.IsDigit(code[i]))
            {
                return false;
            }
        }

        return true;
    }
}
