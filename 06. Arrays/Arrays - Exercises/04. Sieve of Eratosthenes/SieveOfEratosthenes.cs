using System;
using System.Collections.Generic;

class SieveOfEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        List<int> primes = new List<int>();

        for (int i = 2; i <= n; i++)
        {
            for (int k = 2; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                primes.Add(i);
            }

            isPrime = true;
        }

        Console.WriteLine(string.Join(" ", primes));
    }
}
