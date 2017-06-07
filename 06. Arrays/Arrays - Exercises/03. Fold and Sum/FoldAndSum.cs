using System;
using System.Linq;

class FoldAndSum
{
    static void Main()
    {
        int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int[] edges = new int[nums.Length / 2];
        int[] middle = new int[nums.Length / 2];
        int[] sumLayers = new int[nums.Length / 2];

        // Calculates edge folds
        for (int i = 0; i < nums.Length / 4; i++)
        {
            edges[i] = nums[nums.Length / 4 - 1 - i];
            edges[edges.Length - 1 - i] = nums[(nums.Length / 4) * 3 + i];
        }

        // Calculates the base
        for (int i = 0; i < nums.Length / 2; i++)
        {
            middle[i] = nums[nums.Length / 4 + i];
        }

        // Sum the obtained two arrays
        for (int i = 0; i < nums.Length / 2; i++)
        {
            sumLayers[i] = edges[i] + middle[i];
        }

        Console.WriteLine(string.Join(" ", sumLayers));
    }
}
