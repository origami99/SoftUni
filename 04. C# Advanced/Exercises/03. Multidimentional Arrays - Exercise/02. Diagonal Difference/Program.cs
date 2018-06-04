using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] matrix = new int[n][];
        for (int i = 0; i < n; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        int firstDiagSum = 0;
        int secondDiagSum = 0;
        for (int i = 0; i < n; i++)
        {
            firstDiagSum += matrix[i][i];
            secondDiagSum += matrix[i][n - i - 1];
        }

        int diagSumDiff = Math.Abs(firstDiagSum - secondDiagSum);

        Console.WriteLine(diagSumDiff);
    }
}
