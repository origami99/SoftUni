using System;
using System.Linq;

class RoundingNumbers
{
    static void Main()
    {
        double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        foreach (var num in arr)
        {
            Console.WriteLine($"{num} => {Math.Round(num, MidpointRounding.AwayFromZero)}");
        }
    }
}
