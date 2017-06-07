using System;

class PrimeChecker
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        bool prime = isPrime(n);

        Console.WriteLine(prime);
    }

    public static bool isPrime(long n)
    {
        if (n == 0 || n == 1)
        {
            return false;
        }

        for (int k = 2; k <= Math.Sqrt(n); k++)
        {
            if (n % k == 0)
            {
                return false;
            }
        }

        return true;
    }
}
