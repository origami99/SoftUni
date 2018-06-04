using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int r = int.Parse(size.First());
        int c = int.Parse(size.Last());

        string[][] matrix = new string[r][];

        for (int row = 0; row < r; row++)
        {
            matrix[row] = new string[c];

            for (int col = 0; col < c; col++)
            {
                string elem = string.Format(
                    $"{(char)(row + 97)}{(char)(col + row + 97)}{(char)(row + 97)}");
                matrix[row][col] = elem;
            }
        }

        foreach (string[] row in matrix)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
