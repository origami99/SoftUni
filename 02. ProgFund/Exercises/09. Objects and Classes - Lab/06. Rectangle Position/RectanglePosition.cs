using System;
using System.Linq;

class Rectangle
{
    public int Left { get; set; }
    public int Top { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Right { get { return Left + Width; } }
    public int Bottom { get { return Top + Height; } }
}

class RectanglePosition
{
    static void Main()
    {
        Rectangle firstRectangle = ReadRectangle();
        Rectangle secondRectangle = ReadRectangle();

        if (isInside(firstRectangle, secondRectangle))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not inside");
        }
    }

    static Rectangle ReadRectangle()
    {
        int[] props = Console.ReadLine()
            .Split(' ')
            .Select(int.Parse)
            .ToArray();

        Rectangle rect = new Rectangle
        {
            Left = props[0],
            Top = props[1],
            Width = props[2],
            Height = props[3]
        };

        return rect;
    }

    static bool isInside(Rectangle r1, Rectangle r2)
    {
        if (r1.Right <= r2.Right && r1.Left >= r2.Left &&
            r1.Top <= r2.Top && r1.Bottom <= r2.Bottom)
        {
            return true;
        }

        return false;
    }
}
