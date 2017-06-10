using System;
using System.Linq;

class UpgradedMatcher
{
    static void Main()
    {
        string[] names = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        decimal[] quantities = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();
        decimal[] prices = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        while (true)
        {
            string[] command = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (command[0] == "done")
            {
                break;
            }

            string productName = command[0];
            decimal productQuantity = decimal.Parse(command[1]);

            for (int i = 0; i < names.Length; i++)
            {
                if (productName == names[i])
                {
                    if (i < quantities.Length)
                    {
                        if (productQuantity <= quantities[i])
                        {
                            decimal orderPrice = productQuantity * prices[i];
                            Console.WriteLine($"{productName} x {productQuantity} costs {orderPrice:F2}");
                            quantities[i] -= productQuantity;
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"We do not have enough {productName}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"We do not have enough {productName}");
                        break;
                    }
                }
            }
        }
    }
}
