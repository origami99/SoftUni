using System;
using System.Linq;

class PairsByDifference
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int diff = int.Parse(Console.ReadLine());
        int countDiffs = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int k = 0; k < arr.Length; k++)
            {
                if (diff == arr[i] - arr[k])
                {
                    countDiffs++;
                }
            }
        }

        Console.WriteLine(countDiffs);
    }
}
