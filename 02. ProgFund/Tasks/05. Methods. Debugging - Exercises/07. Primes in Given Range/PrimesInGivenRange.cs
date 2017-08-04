using System;
using System.Collections.Generic;

class PrimesInGivenRange
{
    static void Main()
    {
        int leftNum = int.Parse(Console.ReadLine());
        int rightNum = int.Parse(Console.ReadLine());

        List<int> primes = new List<int>();

        FindPrimeInRange(leftNum, rightNum, primes);

        Console.WriteLine(string.Join(", ", primes));
    }

    public static List<int> FindPrimeInRange(int leftNum, int rightNum, List<int> primes)
    {
        bool isPrime = true;

        for (int i = leftNum; i <= rightNum; i++)
        {
            for (int k = 2; k <= Math.Sqrt(i); k++)
            {
                if (i % k == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime && i != 0 && i != 1)
            {
                primes.Add(i);
            }

            isPrime = true;
        }

        return primes;
    }
}
