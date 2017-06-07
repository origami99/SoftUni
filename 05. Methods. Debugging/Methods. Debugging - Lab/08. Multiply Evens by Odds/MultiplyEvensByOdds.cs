using System;

class MultiplyEvensByOdds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        n = Math.Abs(n);

        int result = MultipleOfDigits(n);

        Console.WriteLine(result);
    }

    public static int MultipleOfDigits(int n)
    {
        int sumEvens = SumOfEvens(n);
        int sumOdds = SumOfOdds(n);
        return sumEvens * sumOdds;
    }

    public static int SumOfEvens(int num)
    {
        int sum = 0;
        int lastDigit = 0;

        while (num > 0)
        {
            lastDigit = num % 10;

            if (lastDigit % 2 == 0)
            {
                sum += lastDigit;
            }

            num /= 10;
        }

        return sum;
    }

    public static int SumOfOdds(int num)
    {
        int sum = 0;
        int lastDigit = 0;

        while (num > 0)
        {
            lastDigit = num % 10;

            if (lastDigit % 2 != 0)
            {
                sum += lastDigit;
            }

            num /= 10;
        }

        return sum;
    }
}
