using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int longerArr = Math.Max(arr1.Length, arr2.Length);

        int[] sumArr = new int[longerArr];

        for (int i = 0; i < longerArr; i++)
        {
            sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        }

        Console.WriteLine(string.Join(" ", sumArr));
    }
}
