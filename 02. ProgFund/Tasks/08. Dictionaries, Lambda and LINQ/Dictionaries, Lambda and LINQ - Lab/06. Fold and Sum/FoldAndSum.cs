using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] sheet = Console.ReadLine()
            .Split()
            .Select(x => int.Parse(x))
            .ToArray();

        int halfLength = sheet.Length / 2;
        int qurterLength = sheet.Length / 4;

        int[] leftPiece = sheet
            .Take(qurterLength)
            .Reverse()
            .ToArray();
        int[] rightPiece = sheet
            .Reverse()
            .Take(qurterLength)
            .ToArray();

        int[] bottomLayer = sheet
            .Skip(qurterLength)
            .Take(halfLength)
            .ToArray();
        int[] topLayer = leftPiece
            .Concat(rightPiece)
            .ToArray();

        int[] summedLayers = new int[halfLength];

        for (int i = 0; i < halfLength; i++)
        {
            summedLayers[i] = bottomLayer[i] + topLayer[i];
        }

        Console.WriteLine(string.Join(" ", summedLayers));
    }
}
