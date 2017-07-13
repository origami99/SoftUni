using System;

class RectangleArea
{
    static void Main()
    {
        double height = double.Parse(Console.ReadLine());
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine($"{height * width:F2}");
    }
}
