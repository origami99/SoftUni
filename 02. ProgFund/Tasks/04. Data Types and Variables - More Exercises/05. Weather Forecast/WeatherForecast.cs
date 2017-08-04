using System;

class WeatherForecast
{
    static void Main()
    {
        string num = Console.ReadLine();
        string weather = "";

        long temp1;
        bool isLong = long.TryParse(num, out temp1);

        int temp2;
        bool isInt = int.TryParse(num, out temp2);

        short temp3;
        bool isShort = short.TryParse(num, out temp3);

        if (isShort)
        {
            weather = "Sunny";
        }
        else if (isInt)
        {
            weather = "Cloudy";
        }
        else if (isLong)
        {
            weather = "Windy";
        }
        else
        {
            weather = "Rainy";
        }

        Console.WriteLine(weather);
    }
}
