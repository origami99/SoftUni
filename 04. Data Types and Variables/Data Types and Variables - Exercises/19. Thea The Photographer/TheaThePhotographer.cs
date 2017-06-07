using System;

class TheaThePhotographer
{
    static void Main()
    {
        int pictures = int.Parse(Console.ReadLine());
        double filterTime = double.Parse(Console.ReadLine());
        int filteredPercent = int.Parse(Console.ReadLine());
        int upload = int.Parse(Console.ReadLine());

        double usefulTotal = Math.Ceiling(filteredPercent / 100.0 * pictures);
        double filterTimeTotal = pictures * filterTime;
        double uploadTimeTotal = upload * usefulTotal;

        double TimeTotal = filterTimeTotal + uploadTimeTotal;

        double days = Math.Floor(TimeTotal / 86400);
        double hours = Math.Floor(TimeTotal / 3600) % 24;
        double mins = Math.Floor(TimeTotal / 60) % 60;
        double secs = TimeTotal % 60;

        Console.WriteLine($"{days}:{hours:00}:{mins:00}:{secs:00}");
    }
}
