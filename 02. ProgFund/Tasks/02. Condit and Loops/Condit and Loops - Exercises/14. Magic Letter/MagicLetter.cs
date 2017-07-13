using System;

class MagicLetter
{
    static void Main()
    {
        char letter1 = char.Parse(Console.ReadLine());
        char letter2 = char.Parse(Console.ReadLine());
        char fuckedLetter = char.Parse(Console.ReadLine());

        for (char i1 = letter1; i1 <= letter2; i1++)
        {
            for (char i2 = letter1; i2 <= letter2; i2++)
            {
                for (char i3 = letter1; i3 <= letter2; i3++)
                {
                    if (i1 != fuckedLetter && i2 != fuckedLetter && i3 != fuckedLetter)
                    {
                        Console.Write($"{i1}{i2}{i3} ");
                    }
                }
            }
        }
    }
}
