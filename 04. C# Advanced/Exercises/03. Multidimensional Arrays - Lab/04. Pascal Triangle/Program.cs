using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[][] pascal = new long[n][];

        for (int i = 0; i < n; i++)
        {
            long[] row = new long[i + 1];
            row[0] = 1;
            row[i] = 1;

            for (int j = 1; j < i; j++)
            {
                row[j] = pascal[i - 1][j - 1] + pascal[i - 1][j];
            }

            pascal[i] = row;
        }

        foreach (long[] row in pascal)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
