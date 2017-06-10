using System;
using System.Linq;

class InventoryMatcher
{
    static void Main()
    {
        string[] names = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        long[] quantities = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();
        decimal[] prices = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        while (true)
        {
            string product = Console.ReadLine();

            if (product == "done")
            {
                break;
            }

            for (int i = 0; i < names.Length; i++)
            {
                if (product == names[i])
                {
                    Console.WriteLine($"{names[i]} costs: {prices[i]}; Available quantity: {quantities[i]}");
                }
            }
        }
    }
}
