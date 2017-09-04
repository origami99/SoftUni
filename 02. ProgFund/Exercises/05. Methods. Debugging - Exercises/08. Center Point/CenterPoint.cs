using System;

class CenterPoint
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        string closesPoint = GetCloestPoint(x1, y1, x2, y2);

        Console.WriteLine(closesPoint);
    }

    public static string GetCloestPoint(double x1, double y1, double x2, double y2)
    {
        double firstDotPosition = Pythagorean(x1, y1);
        double secondDotPosition = Pythagorean(x2, y2);

        if (firstDotPosition <= secondDotPosition)
        {
            return $"({x1}, {y1})";
        }

        return $"({x2}, {y2})";

    }

    public static double Pythagorean(double a, double b)
    {
        return Math.Abs(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
    }
}
