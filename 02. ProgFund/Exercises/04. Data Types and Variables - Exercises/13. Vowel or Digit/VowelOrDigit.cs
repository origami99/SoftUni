using System;

class VowelOrDigit
{
    static void Main()
    {
        char symbol = char.ToLower(char.Parse(Console.ReadLine()));

        if (symbol >= 48 && symbol <= 57)
        {
            Console.WriteLine("digit");
            return;
        }

        int[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        foreach (var vowel in vowels)
        {
            if (symbol == vowel)
            {
                Console.WriteLine("vowel");
                return;
            }
        }

        Console.WriteLine("other");
    }
}
