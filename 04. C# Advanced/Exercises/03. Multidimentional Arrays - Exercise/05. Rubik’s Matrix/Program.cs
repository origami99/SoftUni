using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] size = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int r = int.Parse(size[0]);
        int c = int.Parse(size[1]);

        int[][] rubik = new int[r][];
        int counter = 0;
        for (int row = 0; row < r; row++)
        {
            rubik[row] = new int[c];
            for (int col = 0; col < c; col++)
            {
                rubik[row][col] = ++counter;
            }
        }

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int index = int.Parse(command[0]);
            string direction = command[1];
            int times = int.Parse(command[2]);

            if (direction == "up")
            {
                int[] col = rubik.Select(row => row[index]).ToArray();

                int[] firstPart = col.ToList().Skip(times % r).ToArray();
                int[] secondPart = col.ToList().Take(times % r).ToArray();
                col = firstPart.Concat(secondPart).ToArray();

                for (int j = 0; j < col.Length; j++)
                {
                    rubik[j][index] = col[j];
                }
            }
            else if (direction == "down")
            {
                int[] col = rubik.Select(row => row[index]).ToArray();

                int[] firstPart = col.ToList().Skip(r - (times % r)).ToArray();
                int[] secondPart = col.ToList().Take(r - (times % r)).ToArray();
                col = firstPart.Concat(secondPart).ToArray();

                for (int j = 0; j < col.Length; j++)
                {
                    rubik[j][index] = col[j];
                }
            }
            else if (direction == "left")
            {
                int[] firstPart = rubik[index].ToList().Skip(times % c).ToArray();
                int[] secondPart = rubik[index].ToList().Take(times % c).ToArray();

                rubik[index] = firstPart.Concat(secondPart).ToArray();
            }
            else if (direction == "right")
            {
                int[] firstPart = rubik[index].ToList().Skip(c - (times % c)).ToArray();
                int[] secondPart = rubik[index].ToList().Take(c - (times % c)).ToArray();

                rubik[index] = firstPart.Concat(secondPart).ToArray();
            }
        }

        counter = 0;
        for (int row = 0; row < r; row++)
        {
            for (int col = 0; col < c; col++)
            {
                if (rubik[row][col] != ++counter)
                {
                    for (int i = row; i < r; i++)
                    {
                        for (int j = 0; j < c; j++)
                        {
                            if (rubik[i][j] == counter)
                            {
                                int temp = rubik[row][col];
                                rubik[row][col] = rubik[i][j];
                                rubik[i][j] = temp;

                                Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No swap required");
                }
            }
        }
    }
}
