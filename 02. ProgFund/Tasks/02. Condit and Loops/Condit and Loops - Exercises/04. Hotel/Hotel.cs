using System;

class Hotel
{
    static void Main()
    {
        string month = Console.ReadLine();
        double nights = int.Parse(Console.ReadLine());

        double priceStudio = 0;
        double priceDouble = 0;
        double priceSuite = 0;

        switch (month)
        {
            case "May":
            case "October":
                priceStudio = (50 * nights);
                priceDouble = (65 * nights);
                priceSuite = (75 * nights);
                if (nights > 7)
                {
                    if (month == "October")
                    {
                        priceStudio -= 50;
                    }

                    priceStudio *= 0.95;
                }
                break;
            case "June":
            case "September":
                priceStudio = (60 * nights);
                priceDouble = (72 * nights);
                priceSuite = (82 * nights);
                if (nights > 7 && month == "September")
                {
                    priceStudio -= 60;
                }
                if (nights > 14)
                {
                    priceDouble *= 0.90;
                }
                break;
            case "July":
            case "August":
            case "December":
                priceStudio = (68 * nights);
                priceDouble = (77 * nights);
                priceSuite = (89 * nights);
                if (nights > 14)
                {
                    priceSuite *= 0.85;
                }
                break;
        }

        Console.WriteLine($"Studio: {priceStudio:F2} lv.");
        Console.WriteLine($"Double: {priceDouble:F2} lv.");
        Console.WriteLine($"Suite: {priceSuite:F2} lv.");
    }
}
