using System;
using System.Linq;

class TrippleSum
{
    static void Main()
    {
        long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        bool isVirgin = true;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                for (int k = 0; k < arr.Length; k++)
                {
                    if (arr[i] + arr[j] == arr[k])
                    {
                        Console.WriteLine($"{arr[i]} + {arr[j]} == {arr[k]}");
                        isVirgin = false;
                        break;
                    }
                }
            }
        }

        if (isVirgin)
        {
            Console.WriteLine("No");
        }
    }
}
