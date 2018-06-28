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
        int angle = int.Parse(match.Value);

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
            int spacesCount = c - inputs[row].Length;
            string line = inputs[row] + new string(' ', spacesCount);
            matrix[row] = line.ToArray();
        }

        matrix = Rotate(matrix, angle);

        foreach (char[] row in matrix)
        {
            Console.WriteLine(new string(row));
        }
    }

    private static char[][] Rotate(char[][] matrix, int angle)
    {
        int timesToTotate = (angle % 360) / 90;

        if (timesToTotate == 0)
        {
            return matrix;
        }

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

        return Rotate(rotatedMatrix, angle - 90);
    }
}
