using System;
using System.Collections.Generic;

class ReverseStrings
{
    static void Main()
    {
        string input = Console.ReadLine();

        Stack<char> letters = new Stack<char>();

        foreach (char letter in input)
        {
            letters.Push(letter);
        }

        Console.WriteLine(string.Join("", letters));
    }
}
