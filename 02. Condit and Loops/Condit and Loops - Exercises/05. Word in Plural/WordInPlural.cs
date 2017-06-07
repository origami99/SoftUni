using System;

class WordInPlural
{
    static void Main()
    {
        string noun = Console.ReadLine();

        string pluralWord = noun;

        if (noun.EndsWith("y"))
        {
            pluralWord = noun.Remove(noun.Length - 1, 1);
            pluralWord = $"{pluralWord}ies";
        }
        else if (noun.EndsWith("o") || noun.EndsWith("ch") ||
            noun.EndsWith("s") || noun.EndsWith("sh") ||
            noun.EndsWith("x") || noun.EndsWith("z"))
        {
            pluralWord = $"{pluralWord}es";
        }
        else
        {
            pluralWord = $"{pluralWord}s";
        }

        Console.WriteLine(pluralWord);
    }
}
