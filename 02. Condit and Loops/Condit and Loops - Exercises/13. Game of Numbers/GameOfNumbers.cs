using System;

class GameOfNumbers
{
    static void Main()
    {
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int magicalNum = int.Parse(Console.ReadLine());

        int min = Math.Min(num1, num2);
        int max = Math.Max(num1, num2);

        int counter = 0;

        for (int i = min; i <= max; i++)
        {
            for (int k = min; k <= max; k++)
            {
                counter++;

                if (i + k == magicalNum)
                {
                    Console.WriteLine($"Number found! {k} + {i} = {magicalNum}");
                    return;
                }
            }
        }

        Console.WriteLine($"{counter} combinations - neither equals {magicalNum}");
    }
}
