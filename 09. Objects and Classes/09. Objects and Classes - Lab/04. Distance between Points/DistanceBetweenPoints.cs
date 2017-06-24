using System;
using System.Linq;

class DistanceBetweenPoints
{
    static void Main()
    {
        int[] p1 = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();
        int[] p2 = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        double distance = GetDistance(p1, p2);

        Console.WriteLine($"{distance:F3}");
    }

    private static double GetDistance(int[] p1, int[] p2)
    {
        int x1 = p1.First();
        int y1 = p1.Last();
        int x2 = p2.First();
        int y2 = p2.Last();

        int a = Math.Abs(x1 - x2);
        int b = Math.Abs(y1 - y2);

        double c = Math.Sqrt(a * a + b * b);

        return c;
    }
}
