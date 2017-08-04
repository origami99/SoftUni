using System;

class ConvertSpeedUnits
{
    static void Main()
    {
        float distance = float.Parse(Console.ReadLine());
        float hours = float.Parse(Console.ReadLine());
        float minutes = float.Parse(Console.ReadLine());
        float seconds = float.Parse(Console.ReadLine());

        float hoursTotal = hours + minutes / 60.0f + seconds / 3600.0f;

        float kmSpeed = (distance / 1000.0f) / hoursTotal;
        float metersSpeed = kmSpeed / 3.6f;
        float milesSpeed = (distance / 1609.0f) / hoursTotal;

        Console.WriteLine(metersSpeed);
        Console.WriteLine(kmSpeed);
        Console.WriteLine(milesSpeed);
    }
}
