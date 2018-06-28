using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Regex regex = new Regex(@"\d+");
        Match match = regex.Match(Console.ReadLine());
        int angle = int.Parse(match.Value) % 360;

        List<string> inputs = new List<string>();

        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            inputs.Add(input);
        }

        int r = inputs.Count;
        int c = inputs.Select(x => x.Length).Max();

        char[][] matrix = new char[r][];

        for (int row = 0; row < r; row++)
        {
            string line = inputs[row] + new string(' ', c - inputs[row].Length);
            matrix[row] = line.ToArray();
        }

        switch (angle)
        {
            case 90:
                matrix = Rotate90(matrix);
                break;
            case 180:
                matrix = Rotate180(matrix);
                break;
            case 270:
                matrix = Rotate270(matrix);
                break;
        }

        foreach (char[] row in matrix)
        {
            Console.WriteLine(new string(row));
        }
    }

    private static char[][] Rotate90(char[][] matrix)
    {
        int oldRowLength = matrix.Length;
        int oldColLength = matrix.FirstOrDefault().Length;

        char[][] rotatedMatrix = new char[oldColLength][]
            .Select(x => new char[oldRowLength]).ToArray();

        for (int row = 0; row < rotatedMatrix.Length; row++)
        {
            for (int col = 0; col < rotatedMatrix[row].Length; col++)
            {
                int oldRow = oldRowLength - col - 1;
                int oldCol = row;
                rotatedMatrix[row][col] = matrix[oldRow][oldCol];
            }
        }

        return rotatedMatrix;
    }

    private static char[][] Rotate180(char[][] matrix)
    {
        int oldRowLength = matrix.Length;
        int oldColLength = matrix.FirstOrDefault().Length;

        char[][] rotatedMatrix = new char[oldRowLength][]
            .Select(x => new char[oldColLength]).ToArray();

        for (int row = 0; row < rotatedMatrix.Length; row++)
        {
            for (int col = 0; col < rotatedMatrix[row].Length; col++)
            {
                int oldRow = oldRowLength - row - 1;
                int oldCol = oldColLength - col - 1;
                rotatedMatrix[row][col] = matrix[oldRow][oldCol];
            }
        }

        return rotatedMatrix;
    }

    private static char[][] Rotate270(char[][] matrix)
    {
        int oldRowLength = matrix.Length;
        int oldColLength = matrix.FirstOrDefault().Length;

        char[][] rotatedMatrix = new char[oldColLength][]
            .Select(x => new char[oldRowLength]).ToArray();

        for (int row = 0; row < rotatedMatrix.Length; row++)
        {
            for (int col = 0; col < rotatedMatrix[row].Length; col++)
            {
                int oldRow = col;
                int oldCol = oldColLength - row - 1;
                rotatedMatrix[row][col] = matrix[oldRow][oldCol];
            }
        }

        return rotatedMatrix;
    }
}
