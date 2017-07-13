using System;
using System.Linq;

class RotateAndSum
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());

        int[] sumArr = new int[arr.Length];

        for (int i = 1; i <= k; i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                sumArr[j] += arr[((arr.Length - (i % arr.Length == 0 ? arr.Length : i % arr.Length)) + j) % arr.Length];
            }
        }

        Console.WriteLine(string.Join(" ", sumArr));
    }
}
