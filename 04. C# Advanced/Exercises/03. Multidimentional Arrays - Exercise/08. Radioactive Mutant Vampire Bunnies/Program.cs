using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int r = int.Parse(size.First());
        int c = int.Parse(size.Last());

        int pRow = 0;
        int pCol = 0;
        char[][] lair = new char[r][];

        for (int row = 0; row < r; row++)
        {
            lair[row] = Console.ReadLine().ToCharArray();

            if (lair[row].Contains('P'))
            {
                pRow = row;
                pCol = Array.IndexOf(lair[row], 'P');
                lair[pRow][pCol] = '.';
            }
        }

        string steps = Console.ReadLine();
        bool? hasWon = null;
        int lastPRow = pRow;
        int lastPCol = pCol;

        for (int i = 0; i < steps.Length; i++)
        {
            switch (steps[i])
            {
                case 'R':
                    pCol++;
                    break;
                case 'L':
                    pCol--;
                    break;
                case 'U':
                    pRow--;
                    break;
                case 'D':
                    pRow++;
                    break;
            }

            BunnyМultiplication(ref lair);

            try
            {
                if (lair[pRow][pCol] == 'B') hasWon = false;
            }
            catch (IndexOutOfRangeException)
            {
                hasWon = true;
            }

            if (hasWon.HasValue) break;

            lastPRow = pRow;
            lastPCol = pCol;
        }

        foreach (char[] row in lair)
        {
            Console.WriteLine(string.Join("", row));
        }
        if ((bool)hasWon)
            Console.WriteLine($"won: {lastPRow} {lastPCol}");
        else
            Console.WriteLine($"dead: {pRow} {pCol}");
    }

    private static void BunnyМultiplication(ref char[][] lair)
    {
        List<Tuple<int, int>> bunnyPositions = new List<Tuple<int, int>>();

        for (int row = 0; row < lair.Length; row++)
        {
            for (int col = 0; col < lair[row].Length; col++)
            {
                if (lair[row][col] == 'B')
                {
                    bunnyPositions.Add(new Tuple<int, int>(row, col));
                }
            }
        }

        foreach (Tuple<int, int> bunnyPos in bunnyPositions)
        {
            int row = bunnyPos.Item1;
            int col = bunnyPos.Item2;

            if (row != lair.Length - 1)
                lair[row + 1][col] = 'B';
            if (row != 0)
                lair[row - 1][col] = 'B';
            if (col != lair[row].Length - 1)
                lair[row][col + 1] = 'B';
            if (col != 0)
                lair[row][col - 1] = 'B';
        }
    }
}
