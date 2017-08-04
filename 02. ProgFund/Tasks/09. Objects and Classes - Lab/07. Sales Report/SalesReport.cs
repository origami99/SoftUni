using System;
using System.Collections.Generic;
using System.Linq;

class Sale
{
    public string Town { get; set; }
    public string Product { get; set; }
    public decimal Price { get; set; }
    public decimal Quantity { get; set; }
}

class SalesReport
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, decimal> townsData = new SortedDictionary<string, decimal>();
        for (int i = 0; i < n; i++)
        {
            Sale sale = ReadSale();

            decimal profit = sale.Price * sale.Quantity;
            if (townsData.ContainsKey(sale.Town))
            {
                townsData[sale.Town] += profit;
            }
            else
            {
                townsData.Add(sale.Town, profit);
            }
        }

        foreach (var town in townsData)
        {
            Console.WriteLine($"{town.Key} -> {town.Value:F2}");
        }
    }

    static Sale ReadSale()
    {
        string[] input = Console.ReadLine()
            .Split(' ')
            .ToArray();

        Sale sale = new Sale
        {
            Town = input[0],
            Product = input[1],
            Price = decimal.Parse(input[2]),
            Quantity = decimal.Parse(input[3])
        };

        return sale;
    }
}
