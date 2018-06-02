using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        HashSet<string> cars = new HashSet<string>();

        while (true)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            if (input[0] == "END") { break; }

            string command = input[0];
            string car = input[1];

            if (command == "IN")
            {
                cars.Add(car);
            }
            else if (command == "OUT")
            {
                cars.Remove(car);
            }
        }

        if (!cars.Any())
        {
            Console.WriteLine("Parking Lot is Empty");
            return;
        }

        Console.WriteLine(string.Join("\n", cars));
    }
}
