using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> nums = new Stack<string>(Console.ReadLine().Split());

        while (true)
        {
            Console.Write(nums.Pop());

            if (nums.Count == 0)
            {
                break;
            }

            Console.Write(" ");
        }

        Console.WriteLine();
    }
}
