using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string snake = Console.ReadLine();
        int[] shotParameters = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int r = int.Parse(size.First());
        int c = int.Parse(size.Last());

        char[][] stairs = FillStairsWithSnakes(snake, r, c);

        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                if (IsShooted(shotParameters, row, col))
                {
                    stairs[row][col] = ' ';
                }
            }
        }

        PartsFallDown(ref stairs);

        foreach (char[] stair in stairs)
        {
            Console.WriteLine(string.Join("", stair));
        }
    }

    private static char[][] FillStairsWithSnakes(string snake, int r, int c)
    {
        char[][] stairs = new char[r][];
        for (int row = 0; row < r; row++)
        {
            stairs[row] = new char[c];
        }

        int counter = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                char snakePart = snake[counter++ % (snake.Length)];

                if (row % 2 == 0)
                {
                    stairs[r - row - 1][c - col - 1] = snakePart;
                }
                else
                {
                    stairs[r - row - 1][col] = snakePart;
                }
            }
        }

        return stairs;
    }

    private static bool IsShooted(int[] shotParameters, int row, int col)
    {
        int impactRow = shotParameters[0];
        int impactCol = shotParameters[1];
        int radius = shotParameters[2];

        int distanceX = Math.Abs(impactRow - row);
        int distanceY = Math.Abs(impactCol - col);

        double distance = Math.Sqrt(distanceX * distanceX + distanceY * distanceY);

        bool isShooted = distance <= radius;
        return isShooted;
    }

    private static void PartsFallDown(ref char[][] stairs)
    {
        for (int i = 0; i < stairs[0].Length; i++)
        {
            char[] col = stairs.Select(row => row[i]).ToArray();

            char[] fistArr = col.Where(x => x != ' ').ToArray();
            char[] secondArr = Enumerable.Repeat(' ', col.Length - fistArr.Length).ToArray();
            col = secondArr.Concat(fistArr).ToArray();

            for (int j = 0; j < col.Length; j++)
            {
                stairs[j][i] = col[j];
            }
        }
    }
}
