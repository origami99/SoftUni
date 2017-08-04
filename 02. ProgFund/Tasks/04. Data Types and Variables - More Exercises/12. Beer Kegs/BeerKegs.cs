using System;

class BeerKegs
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        double maxVolume = 0;
        string biggestModel = "";

        for (byte i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double r = double.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double volume = Math.PI * r * r * h;

            if (volume >= maxVolume)
            {
                maxVolume = volume;
                biggestModel = model;
            }
        }

        Console.WriteLine(biggestModel);
    }
}
