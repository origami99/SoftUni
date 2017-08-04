using System;

class BackIn30Minutes
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int mins = int.Parse(Console.ReadLine());

        mins += 30;

        if (mins >= 60)
        {
            hours++;
            mins %= 60;
        }
        if (hours >= 24)
        {
            hours %= 24;
        }

        Console.WriteLine($"{hours}:{mins:D2}");
    }
}
