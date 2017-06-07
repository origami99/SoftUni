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

        int countEqualSums = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int leftSum = 0;
            int rightSum = 0;

            // It's not working, cuz not passes through all cases,
            for (int j = 0; j < arr.Length; j++)
            {
                if (j <= i)
                {
                    leftSum += arr[j];
                }
                else
                {
                    break;
                }
            }

            for (int k = 0; k < arr.Length; k++)
            {
                if (k <= i)
                {
                    rightSum += arr[(arr.Length - 1) - k];
                }
                else
                {
                    break;
                }
            }

            if (leftSum == rightSum)
            {
                countEqualSums++;
            }
        }

        if (countEqualSums != 0)
        {
            Console.WriteLine(countEqualSums);
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
