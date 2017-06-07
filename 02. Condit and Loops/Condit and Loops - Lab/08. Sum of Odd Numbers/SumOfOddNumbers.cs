using System;

class SumOfOddNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int currentOdd = 1;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(currentOdd);
            sum += currentOdd;
            currentOdd += 2;
        }

        Console.WriteLine($"Sum: {sum}");
    }
}
