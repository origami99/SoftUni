using System;

class Megapixels
{
    static void Main()
    {
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());

        double pixels = width * height;
        double megaPixels = pixels / 1000000.0d;

        Console.WriteLine($"{width}x{height} => {Math.Round(megaPixels, 1)}MP");
    }
}
