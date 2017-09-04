using System;
using System.Linq;

class Point
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Circle
{
    public Point Center { get; set; }
    public int Radius { get; set; }
}

class CirclesIntersection
{
    static void Main()
    {
        Circle firstCircle = ReadCircle();
        Circle secondCircle = ReadCircle();

        if (Intersect(firstCircle, secondCircle))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static Circle ReadCircle()
    {
        int[] props = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Point point = new Point
        {
            X = props[0],
            Y = props[1]
        };

        Circle circle = new Circle();
        circle.Center = point;
        circle.Radius = props[2];

        return circle;
    }

    static bool Intersect(Circle firstCircle, Circle secondCircle)
    {
        double distanceBetweenCenters = DistanceBetweenCenters(
            firstCircle.Center, secondCircle.Center);

        if (distanceBetweenCenters <= firstCircle.Radius + secondCircle.Radius)
        {
            return true;
        }

        return false;
    }

    private static double DistanceBetweenCenters(Point p1, Point p2)
    {
        int leg1 = Math.Abs(p1.X - p2.X);
        int leg2 = Math.Abs(p1.Y - p2.Y);

        double distance = Math.Sqrt(leg1 * leg1 + leg2 * leg2);

        return distance;
    }
}
