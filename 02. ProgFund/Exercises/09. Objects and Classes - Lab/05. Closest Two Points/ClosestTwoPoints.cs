using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class ClosestTwoPoints
{
    static void Main()
    {
        Point[] points = ReadPoints();

        Point[] closestPoints = GetClosestTwoPoints(points);

        PrintResult(closestPoints);
    }

    private static Point[] ReadPoints()
    {
        int n = int.Parse(Console.ReadLine());

        Point[] points = new Point[n];

        for (int i = 0; i < n; i++)
        {
            points[i] = ReadPoint();
        }

        return points;
    }

    private static Point[] GetClosestTwoPoints(Point[] points)
    {
        double minDistance = double.MaxValue;
        Point[] closestPoints = null;
        for (int i = 0; i < points.Length; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                double distance = GetDistance(points[i], points[j]);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestPoints = new Point[] { points[i], points[j] };
                }
            }
        }

        return closestPoints;
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

    private static void PrintResult(Point[] points)
    {
        double distance = GetDistance(points[0], points[1]);
        Console.WriteLine($"{distance:F3}");

        foreach (var p in points)
        {
            Console.WriteLine($"({p.X}, {p.Y})");
        }
    }
}
