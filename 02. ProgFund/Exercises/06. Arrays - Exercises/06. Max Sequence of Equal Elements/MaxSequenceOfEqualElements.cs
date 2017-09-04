using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

        int? lastDigit = null;
        int currSeqLenght = 1;
        int currSeqSegment = 0;
        int bestSeqLenght = 0;
        int? bestSeqSegment = null;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == lastDigit)
            {
                currSeqSegment = arr[i];
                currSeqLenght++;

                if (currSeqLenght > bestSeqLenght)
                {
                    bestSeqLenght = currSeqLenght;
                    bestSeqSegment = currSeqSegment;
                }
            }
            else
            {
                currSeqLenght = 1;
            }

            lastDigit = arr[i];
        }

        for (int i = 0; i < bestSeqLenght; i++)
        {
            Console.Write(bestSeqSegment + " ");
        }
    }
}
