using System;

class CenturiesToNanoseconds
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int centuries = n;
        int years = centuries * 100;
        int days = (int)(365.2422 * years);
        int hours = days * 24;
        long minutes = hours * 60;
        long seconds = minutes * 60;
        decimal milliseconds = (decimal)seconds * 1000;
        decimal microseconds = milliseconds * 1000;
        decimal nanoseconds = microseconds * 1000;

        Console.WriteLine($"{n} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
    }
}
