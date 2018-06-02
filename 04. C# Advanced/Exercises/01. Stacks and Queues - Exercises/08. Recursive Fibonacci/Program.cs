using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Dictionary<int, long> memorizedList = new Dictionary<int, long>();
        long result = GetFibonacci(n, memorizedList);

        Console.WriteLine(result);
    }

    private static long GetFibonacci(int n, Dictionary<int, long> memorizedList)
    {
        if (n == 1 || n == 2)
        {
            return 1;
        }
        else if (memorizedList.ContainsKey(n))
        {
            return memorizedList[n];
        }
        else
        {
            long x = GetFibonacci(n - 1, memorizedList) + 
                GetFibonacci(n - 2, memorizedList);

            memorizedList.Add(n, x);

            return x;
        }
    }
}
