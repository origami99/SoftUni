using System;

class RectangleProperties
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double heigth = double.Parse(Console.ReadLine());

        Console.WriteLine((width + heigth) * 2);
        Console.WriteLine(width * heigth);
        Console.WriteLine(Math.Sqrt(width * width + heigth * heigth));
    }
}
