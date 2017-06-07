using System;

class CakeIngredients
{
    static void Main()
    {
        string ingredient = "";
        int counter = 0;

        while (ingredient != "Bake!")
        {
            ingredient = Console.ReadLine();
            if (ingredient != "Bake!")
            {
                counter++;
                Console.WriteLine($"Adding ingredient {ingredient}.");
            }
        }

        Console.WriteLine($"Preparing cake with {counter} ingredients.");
    }
}
