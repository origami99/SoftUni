using System;
using System.Linq;

class JumpAround
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int sum = arr[0];
        int currPos = 0;

        while (true)
        {
            if (currPos + arr[currPos] < arr.Length)
            {
                currPos += arr[currPos];
                sum += arr[currPos];
            }
            else if (currPos - arr[currPos] >= 0)
            {
                currPos -= arr[currPos];
                sum += arr[currPos];
            }
            else
            {
                break;
            }
        }

        Console.WriteLine(sum);
    }
}
