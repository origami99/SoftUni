using System;

class Reversedchars
{
    static void Main()
    {
        char symb1 = char.Parse(Console.ReadLine());
        char symb2 = char.Parse(Console.ReadLine());
        char symb3 = char.Parse(Console.ReadLine());

        Console.WriteLine($"{symb3}{symb2}{symb1}");
    }
}
