using System;
using System.Linq;

class ArrayStatistics
{
    static void Main()
    {
        int[] arr = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int min = FindMin(arr);
        int max = FindMax(arr);
        int sum = CalculateSum(arr);
        double average = CalculateAverage(arr);

        Console.WriteLine($"Min = {min}");
        Console.WriteLine($"Max = {max}");
        Console.WriteLine($"Sum = {sum}");
        Console.WriteLine($"Average = {average}");
    }


    private static int FindMin(int[] arr)
    {
        int minNum = int.MaxValue;

        foreach (var currNum in arr)
        {
            if (currNum < minNum)
            {
                minNum = currNum;
            }
        }

        return minNum;
    }

    private static int FindMax(int[] arr)
    {
        int maxNum = int.MinValue;

        foreach (var currNum in arr)
        {
            if (currNum > maxNum)
            {
                maxNum = currNum;
            }
        }

        return maxNum;
    }

    private static int CalculateSum(int[] arr)
    {
        int sum = 0;

        foreach (var currNum in arr)
        {
            sum += currNum;
        }

        return sum;
    }
    private static double CalculateAverage(int[] arr)
    {
        int sum = CalculateSum(arr);
        double average = (double)sum / arr.Length;
        return average;
    }
}
