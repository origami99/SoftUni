using System;

class CalculateTriangleArea
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double triangleArea = GetArea(width, height);
        Console.WriteLine(triangleArea);
    }

    public static double GetArea(double width, double height)
    {
        double area = (width * height) / 2;
        return area;
    }
}
