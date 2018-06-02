using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Queue<string> cars = new Queue<string>();

        int passCounter = 0;
        while (true)
        {
            string input = Console.ReadLine();

            if (input == "end")
            {
                break;
            }

            if (input != "green")
            {
                cars.Enqueue(input);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars.Count != 0)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passCounter++;
                    }
                }
            }
        }

        Console.WriteLine($"{passCounter} cars passed the crossroads.");
    }
}
