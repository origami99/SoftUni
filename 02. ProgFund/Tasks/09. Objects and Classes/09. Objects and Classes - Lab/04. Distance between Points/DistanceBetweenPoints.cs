using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class DistanceBetweenPoints
{
    static void Main()
    {
        Point p1 = ReadPoint();
        Point p2 = ReadPoint();

        double distance = GetDistance(p1, p2);

        Console.WriteLine($"{distance:F3}");
    }

    private static Point ReadPoint()
    {
        int[] coordinates = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Point p = new Point { X = coordinates[0], Y = coordinates[1] };

        return p;
    }

    private static double GetDistance(Point p1, Point p2)
    {
        int leg1 = Math.Abs(p1.X - p2.X);
        int leg2 = Math.Abs(p1.Y - p2.Y);

        double distance = Math.Sqrt(leg1 * leg1 + leg2 * leg2);

        return distance;
    }
}
