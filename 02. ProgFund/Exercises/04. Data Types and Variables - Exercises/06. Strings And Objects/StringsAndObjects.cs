using System;

class StringsAndObjects
{
    static void Main()
    {
        string word1 = "Hello";
        string word2 = "World";
        object concat = word1 + " " + word2;

        string result = (string)concat;

        Console.WriteLine(result);
    }
}
