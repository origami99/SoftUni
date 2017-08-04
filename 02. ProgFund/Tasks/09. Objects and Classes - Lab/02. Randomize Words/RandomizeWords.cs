using System;
using System.Linq;

class RandomizeWords
{
    static void Main()
    {
        string[] words = Console.ReadLine()
            .Split(' ')
            .ToArray();

        Random rnd = new Random();

        for (int i = 0; i < words.Length; i++)
        {
            int randomPos1 = rnd.Next(0, words.Length);
            int randomPos2 = rnd.Next(0, words.Length);

            string temp = words[randomPos1];
            words[randomPos1] = words[randomPos2];
            words[randomPos2] = temp;
        }

        Console.WriteLine(string.Join("\r\n", words));
    }
}
