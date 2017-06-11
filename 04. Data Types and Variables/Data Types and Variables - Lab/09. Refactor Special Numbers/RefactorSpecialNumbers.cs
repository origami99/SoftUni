using System;

class RefactorSpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        int current = 0;
        bool isEqual = false;

        for (int i = 1; i <= n; i++)
        {
            current = i;
            sum = 0;

            while (current > 0)
            {
                sum += current % 10;
                current /= 10;
            }

            isEqual = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{current} -> {isEqual}");
        }
    }
}
