using System;
using System.Linq;

class EqualSums
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        if (arr.Length <= 1)
        {
            Console.WriteLine(0);
            return;
        }

        int? indexOfEqualSides = null;

        for (int i = 0; i <= arr.Length - 1; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            for (int j = 0; j < i; j++)
            {
                leftSum += arr[j];
            }

            for (int k = i + 1; k < arr.Length; k++)
            {
                rightSum += arr[k];
            }

            if (leftSum == rightSum)
            {
                indexOfEqualSides = i;
            }
        }

        if (indexOfEqualSides.HasValue)
        {
            Console.WriteLine(indexOfEqualSides);
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
