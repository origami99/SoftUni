using System;
using System.Collections.Generic;
using System.Linq;

class SupermarketDatabase
{
    static void Main()
    {
        Dictionary<string, double[]> products = new Dictionary<string, double[]>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stocked")
            {
                break;
            }

            string name = input.Split(' ').First();
            double price = double.Parse(input.Split(' ').Skip(1).First());
            int quantity = int.Parse(input.Split(' ').Last());

            if (products.ContainsKey(name))
            {
                products[name][0] = price;
                products[name][1] += quantity;
            }
            else
            {
                products[name] = new double[] { price, quantity };
            }
        }

        double grandPrice = 0;
        foreach (var item in products)
        {
            double totalPrice = item.Value[0] * item.Value[1];
            grandPrice += totalPrice;

            Console.WriteLine($"{item.Key:F2}: ${item.Value[0]:F2} * {item.Value[1]} = ${totalPrice:F2}");
        }

        Console.WriteLine("------------------------------");

        Console.WriteLine($"Grand Total: ${grandPrice:F2}");
    }
}
