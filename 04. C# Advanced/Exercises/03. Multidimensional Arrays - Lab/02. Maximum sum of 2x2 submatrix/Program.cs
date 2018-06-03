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

        int bestRow = 0;
        int bestCol = 0;
        int maxSum = int.MinValue;
        
        for (int row = 0; row < r - 1; row++)
        {
            for (int col = 0; col < c - 1; col++)
            {
                int sum = matrix[row][col] + matrix[row][col + 1] +
                          matrix[row + 1][col] + matrix[row + 1][col + 1];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine($"{matrix[bestRow][bestCol]} {matrix[bestRow][bestCol + 1]}");
        Console.WriteLine($"{matrix[bestRow + 1][bestCol]} {matrix[bestRow + 1][bestCol + 1]}");
        Console.WriteLine(maxSum);
    }
}
