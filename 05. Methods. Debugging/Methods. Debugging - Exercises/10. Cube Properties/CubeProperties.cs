using System;

class CubeProperties
{
    static void Main()
    {
        double side = double.Parse(Console.ReadLine());
        string parameter = Console.ReadLine();

        double searchingParameter = 0;

        if (parameter == "face")
        {
            searchingParameter = GetFaceDiagonals(side);
        }
        else if (parameter == "space")
        {
            searchingParameter = GetSpaceDiagonals(side);
        }
        else if (parameter == "volume")
        {
            searchingParameter = GetVolume(side);
        }
        else if (parameter == "area")
        {
            searchingParameter = GetArea(side);
        }

        Console.WriteLine($"{searchingParameter:f2}");
    }

    private static double GetFaceDiagonals(double side)
    {
        return Math.Sqrt(2 * Math.Pow(side, 2));
    }

    private static double GetSpaceDiagonals(double side)
    {
        return Math.Sqrt(3 * Math.Pow(side, 2));
    }

    private static double GetVolume(double side)
    {
        return Math.Pow(side, 3);
    }

    private static double GetArea(double side)
    {
        return 6 * Math.Pow(side, 2);
    }

    // length of the face diagonals = √(2 * s) ^ 2
    // space diagonals = √(3 * s) ^ 2
    // volume = s ^ 3
    // surface = 6 * (s ^ 2)
}
