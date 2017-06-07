using System;

class LongerLine
{
    static void Main()
    {
        double x1 = double.Parse(Console.ReadLine());
        double y1 = double.Parse(Console.ReadLine());
        double x2 = double.Parse(Console.ReadLine());
        double y2 = double.Parse(Console.ReadLine());

        double x3 = double.Parse(Console.ReadLine());
        double y3 = double.Parse(Console.ReadLine());
        double x4 = double.Parse(Console.ReadLine());
        double y4 = double.Parse(Console.ReadLine());

        string longerLine = GetLongerLine(x1, y1, x2, y2, x3, y3, x4, y4);

        Console.WriteLine(longerLine);
    }

    public static string GetLongerLine(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        double firstPointToCenter = Pythagorean(x1, y1);
        double secondPointToCenter = Pythagorean(x2, y2);
        double thirdPointToCenter = Pythagorean(x3, y3);
        double fourthPointToCenter = Pythagorean(x4, y4);

        double firstLineLength = GetLineLength(x1, y1, x2, y2);
        double secondLineLength = GetLineLength(x3, y3, x4, y4);

        if (firstLineLength >= secondLineLength)
        {
            if (firstPointToCenter <= secondPointToCenter)
            {
                return $"({x1}, {y1})({x2}, {y2})";
            }
            else
            {
                return $"({x2}, {y2})({x1}, {y1})";
            }
        }
        else
        {
            if (thirdPointToCenter <= fourthPointToCenter)
            {
                return $"({x3}, {y3})({x4}, {y4})";
            }
            else
            {
                return $"({x4}, {y4})({x3}, {y3})";
            }
        }
    }

    public static double GetLineLength(double a1, double b1, double a2, double b2)
    {
        double firstLeg = a1 - a2, secondLeg = b1 - b2;
        return Math.Abs(Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2)));
    }

    public static double Pythagorean(double a, double b)
    {
        return Math.Abs(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
    }
}
