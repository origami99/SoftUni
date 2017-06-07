using System;

class ChooseADrinkV2
{
    static void Main()
    {
        string profession = Console.ReadLine();
        int quantity = int.Parse(Console.ReadLine());

        switch (profession)
        {
            case "Athlete":
                Console.WriteLine($"The {profession} has to pay {0.7 * quantity:F2}.");
                break;
            case "Businessman":
            case "Businesswoman":
                Console.WriteLine($"The {profession} has to pay {quantity:F2}.");
                break;
            case "SoftUni Student":
                Console.WriteLine($"The {profession} has to pay {1.7 * quantity:F2}.");
                break;
            default:
                Console.WriteLine($"The {profession} has to pay {1.2 * quantity:F2}.");
                break;
        }
    }
}