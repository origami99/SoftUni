﻿using System;

class EvenOrOdd
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine("even");
        }
        else if (num % 2 == 1)
        {
            Console.WriteLine("odd");
        }
    }
}
