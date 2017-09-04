using System;

class HouseBuilder
{
    static void Main()
    {
        long firstPrice = long.Parse(Console.ReadLine());
        long secondPrice = long.Parse(Console.ReadLine());
        
        long totalPrice = 0;

        if (firstPrice > 127) // firstPrice is the 32bit (int)
        {
            totalPrice += firstPrice * 10;
            totalPrice += secondPrice * 4;
        }
        else // firstPrice is the 8bit (sbyte)
        {
            totalPrice += firstPrice * 4;
            totalPrice += secondPrice * 10;
        }

        Console.WriteLine(totalPrice);
    }
}
