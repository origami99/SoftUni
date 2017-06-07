using System;

class TrainingHallEquipment
{
    static void Main()
    {
        double budget = double.Parse(Console.ReadLine());
        int itemsCount = int.Parse(Console.ReadLine());

        double spend = 0;

        for (int i = 0; i < itemsCount; i++)
        {
            string itemName = Console.ReadLine();
            double itemPrice = double.Parse(Console.ReadLine());
            int itemUnits = int.Parse(Console.ReadLine());

            string emptyOrS = "";
            if (itemUnits > 1)
            {
                emptyOrS = "s";
            }

            spend += itemPrice * itemUnits;
            Console.WriteLine($"Adding {itemUnits} {itemName}{emptyOrS} to cart.");
        }

        double moneyLeft = budget - spend;

        Console.WriteLine($"Subtotal: ${spend:F2}");

        if (moneyLeft >= 0)
        {
            Console.WriteLine($"Money left: ${moneyLeft:F2}");
        }
        else
        {
            Console.WriteLine($"Not enough. We need ${Math.Abs(moneyLeft):F2} more.");
        }
    }
}
