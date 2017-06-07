using System;

class GeometryCalculator
{
    static void Main()
    {
        string figure = Console.ReadLine();

        double area = 0;

        if (figure == "triangle")
        {
            area = GetTriangleArea();
        }
        else if (figure == "square")
        {
            area = GetSquareArea();
        }
        else if (figure == "rectangle")
        {
            area = GetRectangleArea();
        }
        else if (figure == "circle")
        {
            area = GetCircleArea();
        }

        Console.WriteLine($"{area:f2}");
    }

    private static double GetTriangleArea()
    {
        double side = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        return (side * height) / 2;
    }

    private static double GetSquareArea()
    {
        double side = double.Parse(Console.ReadLine());

        return Math.Pow(side, 2);
    }

    private static double GetRectangleArea()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        return width * height;
    }

    private static double GetCircleArea()
    {
        double radius = double.Parse(Console.ReadLine());

        return Math.PI * Math.Pow(radius, 2);
    }
}
