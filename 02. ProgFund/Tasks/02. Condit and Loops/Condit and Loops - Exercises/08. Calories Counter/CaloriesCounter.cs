using System;

class CaloriesCounter
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string ingredien = "";
        int calories = 0;
        
        for (int i = 0; i < n; i++)
        {
            ingredien = Console.ReadLine().ToLower();

            if (ingredien == "cheese")
            {
                calories += 500;
            }
            else if (ingredien == "tomato sauce")
            {
                calories += 150;
            }
            else if (ingredien == "salami")
            {
                calories += 600;
            }
            else if (ingredien == "pepper")
            {
                calories += 50;
            }
        }

        Console.WriteLine($"Total calories: {calories}");
    }
}

