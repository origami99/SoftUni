using System;

class IndexOfLetters
{
    static void Main()
    {
        string word = Console.ReadLine();

        foreach (var letter in word)
        {
            Console.WriteLine($"{letter} -> {letter - 97}");
        }
    }
}
