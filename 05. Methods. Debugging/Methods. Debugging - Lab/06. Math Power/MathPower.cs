using System;

class MathPower
{
    static void Main()
    {
        double _base = double.Parse(Console.ReadLine());
        double exponent = double.Parse(Console.ReadLine());

        double result = Power(exponent, _base);

        Console.WriteLine(result);
    }

    public static double Power(double exponent, double _base)
    {
        double result = 1;

        for (int i = 0; i < exponent; i++)
        {
            result *= _base;
        }

        return result;
    }
}
