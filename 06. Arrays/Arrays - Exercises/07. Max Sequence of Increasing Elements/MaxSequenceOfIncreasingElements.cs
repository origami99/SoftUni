using System;
using System.Linq;

class MaxSequenceOfIncreasingElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        if (arr.Length == 1)
        {
            return;
        }

        int? lastElem = null;
        int currSeqLen = 1;
        int bestSeqLen = 0;
        int? bestLenLastElemIndex = null;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > lastElem)
            {
                currSeqLen++;

                if (currSeqLen > bestSeqLen)
                {
                    bestSeqLen = currSeqLen;
                    bestLenLastElemIndex = i;
                }
            }
            else
            {
                currSeqLen = 1;
            }

            lastElem = arr[i];
        }

        for (int i = (int)bestLenLastElemIndex - bestSeqLen + 1; i <= bestLenLastElemIndex; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
