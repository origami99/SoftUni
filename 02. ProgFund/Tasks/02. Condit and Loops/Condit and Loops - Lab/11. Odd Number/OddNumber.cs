﻿using System;

class OddNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        while ((n % 2 == 0))
        {
            Console.WriteLine("Please write an odd number.");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"The number is: {Math.Abs(n)}");
    }
}