using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        bool isCloseEnough = Math.Abs(a - b) <= 0.000001;

        Console.WriteLine(isCloseEnough);
    }
}
