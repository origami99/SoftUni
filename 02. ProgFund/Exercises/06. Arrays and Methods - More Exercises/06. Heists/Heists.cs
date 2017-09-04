using System;
using System.Linq;

class Heists
{
    static void Main()
    {
        // First element is the price of jewels, second is the price of gold
        long[] prices = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();
        string[] balance = new string[1];

        long jewelPrice = prices[0];
        long goldPrice = prices[1];

        long netIncome = 0;

        while (true)
        {
            // First element is the loot and second - the expenses
            // JEWELS are %, GOLD is $, GOODIES are other symbols
            balance = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (string.Format($"{balance[0]} {balance[1]}") == "Jail Time")
            {
                break;
            }

            long loot = 0;
            long expenses = long.Parse(balance[1]);

            for (int i = 0; i < balance[0].Length; i++)
            {
                switch (balance[0][i])
                {
                    case '%':
                        loot += jewelPrice;
                        break;
                    case '$':
                        loot += goldPrice;
                        break;
                }
            }

            netIncome += loot - expenses;
        }

        if (netIncome >= 0)
        {
            Console.WriteLine($"Heists will continue. Total earnings: {netIncome}.");
        }
        else
        {
            Console.WriteLine($"Have to find another job. Lost: {Math.Abs(netIncome)}.");
        }
    }
}
