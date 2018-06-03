using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(size[0]);
        int h = int.Parse(size[1]);

        int[][] matrix = new int[r][];
        for (int row = 0; row < r; row++)
        {
            int[] rowNums = Console.ReadLine()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            matrix[row] = rowNums;
        }

        int sum = 0;

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                sum += matrix[row][col];
            }
        }

        Console.WriteLine(matrix.Length);
        Console.WriteLine(matrix[0].Length);
        Console.WriteLine(sum);
    }
}
