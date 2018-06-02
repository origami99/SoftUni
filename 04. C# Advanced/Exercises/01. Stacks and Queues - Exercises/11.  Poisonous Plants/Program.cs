using System;
using System.Collections.Generic;
using System.Linq;

public class PoisonousPlants
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

        Stack<int> indexes = new Stack<int>();
        indexes.Push(0);

        int[] days = new int[n];

        for (int i = 1; i < n; i++)
        {
            int daysCount = 0;

            while (indexes.Count > 0 && plants[indexes.Peek()] >= plants[i])
            {
                daysCount = Math.Max(daysCount, days[indexes.Pop()]);
            }

            if (indexes.Count > 0)
            {
                days[i] = daysCount + 1;
            }

            indexes.Push(i);
        }

        Console.WriteLine(days.Max());
    }
}
