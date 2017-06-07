using System;

class FastPrimeChecker
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= num; i++)
        {
            if (i != 0 && i != 1)
                Console.WriteLine($"{i} -> {PrimeOrNot(i)}");
        }
    }

    public static bool PrimeOrNot(int i)
    {
        bool isPrime = true;

        for (int k = 2; k <= Math.Sqrt(i); k++)
        {
            if (i % k == 0)
            {
                isPrime = false;
                break;
            }
        }
        return isPrime;
    }
}
