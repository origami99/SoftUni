using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string pikaWord = Console.ReadLine();

        int counter = 0;
        while (true)
        {
            counter++;

            bool noMatchDidi = false;
            bool noMatchBojo = false;

            if (counter % 2 != 0)
            {
                if (!Regex.IsMatch(pikaWord, @"[^A-Za-z\-]+"))
                {
                    noMatchDidi = true;
                }

                string didiMatch = Regex.Match(pikaWord, @"[^A-Za-z\-]+").ToString();
                Console.WriteLine(didiMatch);

                int indexWord = pikaWord.IndexOf(didiMatch);
                pikaWord = pikaWord.Substring(didiMatch.Length + indexWord);
            }
            else
            {
                if (!Regex.IsMatch(pikaWord, @"[A-Za-z]+\-[A-Za-z]+"))
                {
                    noMatchBojo = true;
                }

                string bojoMatch = Regex.Match(pikaWord, @"[A-Za-z]+\-[A-Za-z]+").ToString();
                Console.WriteLine(bojoMatch);

                int indexWord = pikaWord.IndexOf(bojoMatch);
                indexWord = pikaWord.LastIndexOf(bojoMatch);

                pikaWord = pikaWord.Substring(bojoMatch.Length + indexWord);
            }

            if (pikaWord.Length <= 0 || (noMatchDidi && noMatchBojo))
            {
                break;
            }
        }
    }
}
