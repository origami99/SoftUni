using System;

class DifferentIntegersSize
{
    static void Main()
    {
        var n = Console.ReadLine();

        sbyte ignore1;
        byte ignore2;
        short ignore3;
        ushort ignore4;
        int ignore5;
        uint ignore6;
        long ignore7;

        if (sbyte.TryParse(n, out ignore1) || byte.TryParse(n, out ignore2) ||
            short.TryParse(n, out ignore3) || ushort.TryParse(n, out ignore4) ||
            int.TryParse(n, out ignore5) || long.TryParse(n, out ignore7))
            Console.WriteLine($"{n} can fit in:");

        if (sbyte.TryParse(n, out ignore1))
            Console.WriteLine("* sbyte");
        if (byte.TryParse(n, out ignore2))
            Console.WriteLine("* byte");
        if (short.TryParse(n, out ignore3))
            Console.WriteLine("* short");
        if (ushort.TryParse(n, out ignore4))
            Console.WriteLine("* ushort");
        if (int.TryParse(n, out ignore5))
            Console.WriteLine("* int");
        if (uint.TryParse(n, out ignore6))
            Console.WriteLine("* uint");
        if (long.TryParse(n, out ignore7))
            Console.WriteLine("* long");
        else
            Console.WriteLine($"{n} can't fit in any type");
    }
}
