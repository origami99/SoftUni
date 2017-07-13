using System;

class RefactorVolumeOfPyramid
{
    static void Main()
    {
        double l, w, h, v = 0;
        l = double.Parse(Console.ReadLine());
        w = double.Parse(Console.ReadLine());
        h = double.Parse(Console.ReadLine());

        v = (l + w + h);
        Console.WriteLine($"Length: Width: Height: Pyramid Volume: {v:f2}");
    }
}
