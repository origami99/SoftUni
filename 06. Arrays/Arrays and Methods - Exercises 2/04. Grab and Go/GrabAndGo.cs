using System;
using System.Linq;

class GrabAndGo
{
    static void Main()
    {
        long[] arr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse)
            .ToArray();
        long num = long.Parse(Console.ReadLine());

        int? specialIndex = null;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                specialIndex = i;
            }
        }

        if (!(specialIndex.HasValue))
        {
            Console.WriteLine("No occurrences were found!");
            return;
        }

        long sum = 0;
        for (int i = 0; i < specialIndex; i++)
        {
            sum += arr[i];
        }

        Console.WriteLine(sum);
    }
}
