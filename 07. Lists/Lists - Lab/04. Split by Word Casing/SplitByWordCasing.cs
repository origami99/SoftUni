using System;
using System.Linq;
using System.Collections.Generic;

class SplitByWordCasing
{
    static void Main()
    {
        string text = Console.ReadLine();

        char[] separators = {
            ',', ';', ':', '.', '!', '(', ')',
            '"', '\'', '\\', '/', '[', ']', ' ' };

        string[] words = text
            .Split(separators, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        List<string> lowerCase = new List<string>();
        List<string> upperCase = new List<string>();
        List<string> mixedCase = new List<string>();

        for (int i = 0; i < words.Length; i++)
        {
            bool isLowerCase = IsLowerCase(words, i);
            bool isUpperCase = IsUpperCase(words, i);

            if (isLowerCase)
            {
                lowerCase.Add(words[i]);
            }
            else if (isUpperCase)
            {
                upperCase.Add(words[i]);
            }
            else
            {
                // it's Mixed Case
                mixedCase.Add(words[i]);
            }
        }
        
        Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
        Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
        Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
    }

    private static bool IsLowerCase(string[] words, int i)
    {
        string currWord = words[i];

        foreach (var symb in currWord)
        {
            if (symb < 'a' || symb > 'z')
            {
                return false;
            }
        }

        return true;
    }

    private static bool IsUpperCase(string[] words, int i)
    {
        string currWord = words[i];

        foreach (var symb in currWord)
        {
            if (symb < 'A' || symb > 'Z')
            {
                return false;
            }
        }

        return true;
    }
}
