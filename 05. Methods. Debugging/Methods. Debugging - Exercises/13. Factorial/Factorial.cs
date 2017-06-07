using System;
using System.Numerics;

class Factorial
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = Fact(n);

        Console.WriteLine(factorial);
    }

    public static BigInteger Fact(int n)
    {
        BigInteger result = 1;

        while (n >= 1)
        {
            result *= n;
            n--;
        }

        return result;
    }
}
