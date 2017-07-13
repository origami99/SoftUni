using System;
using System.Linq;

class PizzaIngredients
{
    static void Main()
    {
        string[] ingredients = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToArray();
        int specLength = int.Parse(Console.ReadLine());

        int countIngreds = 0;
        string[] addedIngreds = new string[10];

        for (int i = 0; i < ingredients.Length; i++)
        {
            if (ingredients[i].Length == specLength)
            {
                addedIngreds[countIngreds] = ingredients[i];

                Console.WriteLine($"Adding {ingredients[i]}.");
                countIngreds++;

                if (countIngreds >= 10)
                {
                    break;
                }
            }
        }

        Console.WriteLine($"Made pizza with total of {countIngreds} ingredients.");
        Console.WriteLine($"The ingredients are: {string.Join(", ", addedIngreds).Trim(' ', ',')}.");
    }
}
