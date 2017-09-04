using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int digit = 0;
        int sum = 0;
        int current = 0;

        for (int i = 1; i <= n; i++)
        {
            current = i;

            while (current > 0)
            {
                digit = current % 10;
                sum += digit;
                current /= 10;
            }
            bool isEqual = sum == 5 || sum == 7 || sum == 11;
            Console.WriteLine($"{i} -> {isEqual}");

            sum = 0;
        }
    }
}
