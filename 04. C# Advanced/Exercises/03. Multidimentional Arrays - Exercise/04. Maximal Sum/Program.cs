using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(size[0]);
        int c = int.Parse(size[1]);

        int[][] matrix = new int[r][];
        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        int maxSum = int.MinValue;
        int[][] maxMatrix = new int[3][];

        for (int row = 0; row < r - 2; row++)
        {
            for (int col = 0; col < c - 2; col++)
            {
                int[][] subMatrix = new int[3][];

                int sum = GetSum(matrix, ref subMatrix, row, col);

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxMatrix = subMatrix;
                }
            }
        }

        Console.WriteLine($"Sum = {maxSum}");
        foreach (int[] row in maxMatrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }

    private static int GetSum(int[][] matrix, ref int[][] subMatrix, int row, int col)
    {
        int sum = 0;

        for (int i = 0; i < 3; i++)
        {
            subMatrix[i] = new int[3];
            int subRow = row + i;

            for (int j = 0; j < 3; j++)
            {
                int subCol = col + j;
                subMatrix[i][j] = matrix[subRow][subCol];
            }

            sum += subMatrix[i].Sum();
        }

        return sum;
    }
}
