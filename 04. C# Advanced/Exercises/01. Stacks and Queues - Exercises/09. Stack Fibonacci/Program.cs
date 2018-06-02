using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<long> fibonacci = new Stack<long>();
        fibonacci.Push(0);
        fibonacci.Push(1);

        for (int i = 0; i < n - 1; i++)
        {
            // getting last two nums of the sequence
            long a = fibonacci.Pop();
            long b = fibonacci.Peek();
            fibonacci.Push(a);

            // obtaining the next num of the sequence
            long x = a + b;
            fibonacci.Push(x);
        }

        Console.WriteLine(fibonacci.Peek());
    }
}
