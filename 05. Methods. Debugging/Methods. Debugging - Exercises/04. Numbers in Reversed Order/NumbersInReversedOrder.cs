using System;

class NumbersInReversedOrder
{
    static void Main()
    {
        string num = Console.ReadLine();

        for (int i = 0; i < num.Length; i++)
        {
            Console.Write(num[num.Length - 1 - i]);
        }

        Console.WriteLine();
    }
}
