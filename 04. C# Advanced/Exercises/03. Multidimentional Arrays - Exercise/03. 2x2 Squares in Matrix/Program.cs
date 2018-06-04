using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split();
        int r = int.Parse(size.First());
        int c = int.Parse(size.Last());

        char[][] matrix = new char[r][];

        for (int row = 0; row < r; row++)
        {
            matrix[row] = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
        }

        int counter = 0;
        for (int row = 0; row < r - 1; row++)
        {
            for (int col = 0; col < c - 1; col++)
            {
                char elem = matrix[row][col];

                if (elem == matrix[row][col + 1] && 
                    elem == matrix[row + 1][col] && 
                    elem == matrix[row + 1][col + 1])
                {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
}
