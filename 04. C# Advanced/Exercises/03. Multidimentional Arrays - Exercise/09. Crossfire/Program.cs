using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // TODO => (40/100) in judge
        string[] size = Console.ReadLine().Split();
        int r = int.Parse(size.First());
        int c = int.Parse(size.Last());

        string[][] matrix = new string[r][];
        int counter = 0;
        for (int row = 0; row < r; row++)
        {
            matrix[row] = new string[c];
            for (int col = 0; col < c; col++)
            {
                counter++;
                matrix[row][col] = counter.ToString();
            }
        }

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "Nuke it from orbit")
            {
                break;
            }

            int[] shotParameters = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            DestroyCells(shotParameters, ref matrix);
        }

        foreach (string[] row in matrix)
        {
            Console.WriteLine(string.Join(" ", row.Where(n => n != string.Empty)));
        }
    }

    private static void DestroyCells(int[] shotParameters, ref string[][] matrix)
    {
        int impactRow = shotParameters[0];
        int impactCol = shotParameters[1];
        int radius = shotParameters[2];

        for (int row = impactRow - radius; row <= impactRow + radius; row++)
        {
            if (IsInBounds(row, impactCol, matrix))
            {
                matrix[row][impactCol] = string.Empty;
            }
        }
        for (int col = impactCol - radius; col <= impactCol + radius; col++)
        {
            if (IsInBounds(impactRow, col, matrix))
            {
                matrix[impactRow][col] = string.Empty;
            }
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            if (matrix[i].Any(x => x == string.Empty))
            {
                matrix[i] = matrix[i].Where(n => n != string.Empty).ToArray();
            }

            if (matrix[i].Length == 0)
            {
                matrix = matrix.Take(i).Concat(matrix.Skip(i + 1)).ToArray();
                i--;
            }
        }
    }

    private static bool IsInBounds(int row, int col, string[][] matrix)
    {
        return row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length;
    }
}
