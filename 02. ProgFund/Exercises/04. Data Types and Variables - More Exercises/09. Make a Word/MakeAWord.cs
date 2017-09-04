using System;

class MakeAWord
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string word = "";

        for (int i = 0; i < n; i++)
        {
            char letter = char.Parse(Console.ReadLine());
            word = word + letter;
        }

        Console.WriteLine($"The word is: {word}");
    }
}
