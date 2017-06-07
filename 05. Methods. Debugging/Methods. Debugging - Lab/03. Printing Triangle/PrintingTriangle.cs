using System;

class PrintingTriangle
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // TODO: Make it with only one loop and Math.Abs()
        for (int i = 1; i <= n; i++)
        {
            PrintCol(i);
        }

        for (int i = 1; i <= n - 1; i++)
        {
            PrintCol(n - i);
        }
    }

    public static void PrintCol(int i)
    {
        for (int k = 1; k <= i; k++)
        {
            Console.Write($"{k} ");
        }
        Console.WriteLine();
    }
}
