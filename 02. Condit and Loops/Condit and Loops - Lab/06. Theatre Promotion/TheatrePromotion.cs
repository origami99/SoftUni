using System;

class TheatrePromotion
{
    static void Main()
    {
        string day = Console.ReadLine().ToLower();
        int age = int.Parse(Console.ReadLine());
        int price = 0;

        if (!(age >= 0 && age <= 122))
        {
            Console.WriteLine("Error!");
            return;
        }

        if (age >= 0 && age <= 18)
        {
            if (day == "weekday")
            {
                price = 12;
            }
            else if (day == "weekend")
            {
                price = 15;
            }
            else if (day == "holiday")
            {
                price = 5;
            }
        }
        else if (age > 18 && age <= 64)
        {
            if (day == "weekday")
            {
                price = 18;
            }
            else if (day == "weekend")
            {
                price = 20;
            }
            else if (day == "holiday")
            {
                price = 12;
            }
        }
        else if (age > 64 && age <= 122)
        {
            if (day == "weekday")
            {
                price = 12;
            }
            else if (day == "weekend")
            {
                price = 15;
            }
            else if (day == "holiday")
            {
                price = 10;
            }
        }

        Console.WriteLine(price + "$");
    }
}
