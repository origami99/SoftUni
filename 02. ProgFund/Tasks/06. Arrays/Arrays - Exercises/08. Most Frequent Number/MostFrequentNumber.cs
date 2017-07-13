using System;
using System.Linq;

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int maxRepeat = 0;
        int mostFreqNum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            int repeatCount = 0;

            for (int k = 0; k < arr.Length; k++)
            {
                if (arr[i] == arr[k])
                {
                    repeatCount++;
                }
            }

            if (repeatCount > maxRepeat)
            {
                maxRepeat = repeatCount;
                mostFreqNum = arr[i];
            }
        }

        Console.WriteLine(mostFreqNum);
    }
}
