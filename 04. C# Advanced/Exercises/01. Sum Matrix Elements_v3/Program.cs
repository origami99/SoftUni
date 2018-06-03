using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string size = Console.ReadLine();
        int r = size[0] - '0';
        int c = size[3] - '0';

        int sum = 0;
        for (int row = 0; row < r; row++)
        {
            sum += Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Sum();
        }

        Console.WriteLine($"{r}\n{c}\n{sum}");
    }
}
