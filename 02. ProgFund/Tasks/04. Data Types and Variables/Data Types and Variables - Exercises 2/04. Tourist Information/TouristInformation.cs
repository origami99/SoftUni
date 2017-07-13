using System;

class TouristInformation
{
    static void Main()
    {
        string givenUnit = Console.ReadLine();
        double givenValue = double.Parse(Console.ReadLine());

        string wantedUnit = "";
        double wantedValue = 0;

        switch (givenUnit)
        {
            case "miles":
                wantedUnit = "kilometers";
                wantedValue = givenValue * 1.6;
                break;
            case "inches":
                wantedUnit = "centimeters";
                wantedValue = givenValue * 2.54;
                break;
            case "feet":
                wantedUnit = "centimeters";
                wantedValue = givenValue * 30.0;
                break;
            case "yards":
                wantedUnit = "meters";
                wantedValue = givenValue * 0.91;
                break;
            case "gallons":
                wantedUnit = "liters";
                wantedValue = givenValue * 3.8;
                break;
        }

        Console.WriteLine($"{givenValue} {givenUnit} = {wantedValue:F2} {wantedUnit}");
    }
}
