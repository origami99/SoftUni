using System;
using System.Globalization;

class CountWorkingDays
{
    static void Main()
    {
        DateTime startDate = ReadDateTime();
        DateTime endDate = ReadDateTime();

        int workingDaysCount = CountWorkingDay(startDate, endDate);
        Console.WriteLine(workingDaysCount);
    }

    private static DateTime ReadDateTime()
    {
        DateTime date = DateTime.ParseExact(
            Console.ReadLine(),
            "dd-MM-yyyy",
            CultureInfo.InvariantCulture);

        return date;
    }

    private static int CountWorkingDay(DateTime startDate, DateTime endDate)
    {
        int counter = 0;
        for (DateTime d = startDate; d <= endDate; d = d.AddDays(1))
        {
            if (IsWorkingDay(d))
            {
                counter++;
            }
        }

        return counter;
    }

    private static bool IsWorkingDay(DateTime d)
    {
        DateTime[] officialHolidays = new DateTime[]
        {
                new DateTime(2000, 1, 1), // New Year Eve 
                new DateTime(2000, 3, 3), // Liberation Day
                new DateTime(2000, 5, 1), // Worker’s day 
                new DateTime(2000, 5, 6), // Saint George’s Day
                new DateTime(2000, 5, 24), // Saints Cyril and Methodius Day
                new DateTime(2000, 9, 6), // Unification Day
                new DateTime(2000, 9, 22), // Independence Day
                new DateTime(2000, 11, 1), // National Awakening Day
                new DateTime(2000, 12, 24), // Christmas
                new DateTime(2000, 12, 25), // Christmas
                new DateTime(2000, 12, 26) // Christmas
        };

        if (d.DayOfWeek == DayOfWeek.Saturday ||
            d.DayOfWeek == DayOfWeek.Sunday)
        {
            return false;
        }

        foreach (DateTime h in officialHolidays)
        {
            if (d.Month == h.Month && d.Day == h.Day)
            {
                return false;
            }
        }

        return true;
    }
}
