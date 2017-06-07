using System;

class NumberChecker
{
    static void Main()
    {
        long num;
        bool isInteger = long.TryParse(Console.ReadLine(), out num);

        if (isInteger)
        {
            Console.WriteLine("integer");
        }
        else
        {
            Console.WriteLine("floating-point");
        }
    }
}
