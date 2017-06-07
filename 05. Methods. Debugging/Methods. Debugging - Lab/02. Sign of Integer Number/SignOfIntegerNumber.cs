using System;

class SignOfIntegerNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        PrintSign(n);
    }

    public static void PrintSign(int n)
    {
        if (n < 0)
        {
            Console.WriteLine($"The number {n} is negative.");
        }
        else if (n > 0)
        {
            Console.WriteLine($"The number {n} is positive.");
        }
        else
        {
            Console.WriteLine("The number 0 is zero.");
        }
    }
}
