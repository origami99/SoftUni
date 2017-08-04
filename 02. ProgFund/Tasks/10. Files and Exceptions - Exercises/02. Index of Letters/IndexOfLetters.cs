using System;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine().ToLower();

        foreach (char letter in word)
        {
            Console.WriteLine($"{letter} -> {letter - 97}");
        }
    }
}
