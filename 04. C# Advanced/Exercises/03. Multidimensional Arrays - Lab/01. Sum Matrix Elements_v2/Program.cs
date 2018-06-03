using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(size[0]);
        int c = int.Parse(size[1]);

        int[][] matrix = new int[r][];
        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        int sum = 0;
        foreach (int[] row in matrix)
        {
            sum += row.Sum();
        }

        Console.WriteLine($"{r}\n{c}\n{sum}");
    }
}
