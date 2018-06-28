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
    }

    private static char[][] Rotate90(char[][] matrix)
    {
        throw new NotImplementedException();
    }

    private static char[][] Rotate180(char[][] matrix)
    {
        throw new NotImplementedException();
    }

    private static char[][] Rotate270(char[][] matrix)
    {
        throw new NotImplementedException();
    }
}
