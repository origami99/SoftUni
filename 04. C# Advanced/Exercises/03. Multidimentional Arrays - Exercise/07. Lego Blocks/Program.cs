using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[][] firstBlock = new string[n][];
        for (int i = 0; i < n; i++)
        {
            firstBlock[i] = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries);
        }

        string[][] secondBlock = new string[n][];
        for (int i = 0; i < n; i++)
        {
            secondBlock[i] = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            secondBlock[i] = secondBlock[i].Reverse().ToArray();
        }

        string[][] matchedBlocks = new string[n][];
        for (int i = 0; i < n; i++)
        {
            matchedBlocks[i] = firstBlock[i].Concat(secondBlock[i]).ToArray();
        }

        if (matchedBlocks.All(x => matchedBlocks[0].Length == x.Length))
        {
            foreach (string[] row in matchedBlocks)
            {
                Console.WriteLine("[" + string.Join(", ", row) + "]");
            }
        }
        else
        {
            int cells = 0;
            foreach (string[] row in matchedBlocks)
            {
                cells += row.Length;
            }
            Console.WriteLine("The total number of cells is: " + cells);
        }
    }
}
