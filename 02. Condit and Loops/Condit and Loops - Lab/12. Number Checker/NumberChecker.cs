using System;

class NumberChecker
{
    static void Main()
    {
        try
        {
            double num = double.Parse(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        Console.WriteLine("It is a number.");
    }
}
