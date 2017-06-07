using System;

class TestNumbers
{
    static void Main()
    {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        int boundery = int.Parse(Console.ReadLine());

        int counter = 0;
        int sum = 0;

        for (int i = n1; i > 0; i--)
        {
            for (int k = 1; k <= n2; k++)
            {
                counter++;
                sum += i * k * 3;
                if (sum >= boundery)
                {
                    Console.WriteLine($"{counter} combinations");
                    Console.WriteLine($"Sum: {sum} >= {boundery}");
                    return;
                }
            }
        }

        Console.WriteLine($"{counter} combinations");
        Console.WriteLine($"Sum: {sum}");
    }
}
