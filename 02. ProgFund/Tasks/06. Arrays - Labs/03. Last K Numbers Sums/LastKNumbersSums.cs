using System;

class LastKNumbersSums
{
    static void Main()
    {
        long n = long.Parse(Console.ReadLine());
        long k = long.Parse(Console.ReadLine());

        long[] result = new long[n];
        result[0] = 1;

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j <= k; j++)
            {
                if (i - j >= 0)
                {
                    result[i] += result[i - j];
                }
                else
                {
                    break;
                }
            }
        }

        PrintResult(result);
    }

    public static void PrintResult(long[] result)
    {
        foreach (var num in result)
        {
            Console.Write($"{num} ");
        }

        Console.WriteLine();
    }
}
