using System;
using System.Linq;

class DrawAFailledSquare
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        PrintDases(n);

        for (int i = 0; i < n - 2; i++)
        {
            PrintMiddleRow(n);
        }

        PrintDases(n);
    }

    public static void PrintDases(int n)
    {
        string dashes = new string('-', n * 2);
        Console.WriteLine(dashes);
    }

    public static void PrintMiddleRow(int n)
    {
        string middleMiddle = string.Join("", Enumerable.Repeat(@"\/", n - 1));
        Console.WriteLine($"-{middleMiddle}-");
    }
}
