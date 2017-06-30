using System;
using System.IO;
using System.Text.RegularExpressions;

class PunctuationFinder
{
    static void Main()
    {
        string text = File.ReadAllText("sample_text.txt");
        var punctuacionMarks = Regex.Matches(text , "[.,!?:]");

        int counter = 0;
        foreach (var mark in punctuacionMarks)
        {
            counter++;

            Console.Write(mark);
            if (counter != punctuacionMarks.Count)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}
