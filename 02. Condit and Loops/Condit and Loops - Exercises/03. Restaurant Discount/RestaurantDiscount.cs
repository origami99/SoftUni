using System;

class RestaurantDiscount
{
    static void Main()
    {
        int groupSize = int.Parse(Console.ReadLine());
        string package = Console.ReadLine();

        double priceTotal = 0;
        double packagePrice = 0;
        double discount = 0;

        switch (package)
        {
            case "Normal":
                packagePrice = 500;
                discount = 0.95;
                break;
            case "Gold":
                packagePrice = 750;
                discount = 0.90;
                break;
            case "Platinum":
                packagePrice = 1000;
                discount = 0.85;
                break;
        }

        if (groupSize <= 50)
        {
            priceTotal = (2500 + packagePrice) * discount;
            Console.WriteLine("We can offer you the Small Hall");
        }
        else if (groupSize > 50 && groupSize <= 100)
        {
            priceTotal = (5000 + packagePrice) * discount;
            Console.WriteLine("We can offer you the Terrace");
        }
        else if (groupSize > 100 && groupSize <= 120)
        {
            priceTotal = (7500 + packagePrice) * discount;
            Console.WriteLine("We can offer you the Great Hall");
        }
        else
        {
            Console.WriteLine("We do not have an appropriate hall.");
            return;
        }

        double pricePerPerson = priceTotal / groupSize;
        Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
    }
}
