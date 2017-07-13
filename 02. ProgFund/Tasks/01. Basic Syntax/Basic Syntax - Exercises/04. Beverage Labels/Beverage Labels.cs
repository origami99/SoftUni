using System;

class BeverageLabels
{
    static void Main()
    {
        string name = Console.ReadLine();
        double volume = double.Parse(Console.ReadLine());
        double energy = double.Parse(Console.ReadLine());
        double sugar = double.Parse(Console.ReadLine());

        Console.WriteLine($"{volume}ml {name}:");
        Console.WriteLine($"{volume * energy / 100}kcal, {sugar * volume / 100}g sugars");
    }
}
